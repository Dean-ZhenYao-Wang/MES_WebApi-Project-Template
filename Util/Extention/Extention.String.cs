using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Util
{
    public static partial class Extention
    {
        /// <summary>
        /// Base64Url编码
        /// </summary>
        /// <param name="text">待编码的文本字符串</param>
        /// <returns>编码的文本字符串</returns>
        public static string Base64UrlEncode(this string text)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(text);
            string base64 = Convert.ToBase64String(plainTextBytes).Replace('+', '-').Replace('/', '_').TrimEnd('=');

            return base64;
        }

        /// <summary>
        /// HMACSHA256算法
        /// </summary>
        /// <param name="text">内容</param>
        /// <param name="secret">密钥</param>
        /// <returns></returns>
        public static string ToHMACSHA256String(this string text, string secret)
        {
            secret ??= "";
            byte[] keyByte = Encoding.UTF8.GetBytes(secret);
            byte[] messageBytes = Encoding.UTF8.GetBytes(text);
            using HMACSHA256 hmacsha256 = new HMACSHA256(keyByte);
            byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
            return Convert.ToBase64String(hashmessage).Replace('+', '-').Replace('/', '_').TrimEnd('=');
        }

        /// <summary>
        /// Base64Url解码
        /// </summary>
        /// <param name="base64UrlStr">使用Base64Url编码后的字符串</param>
        /// <returns>解码后的内容</returns>
        public static string Base64UrlDecode(this string base64UrlStr)
        {
            base64UrlStr = base64UrlStr.Replace('-', '+').Replace('_', '/');
            switch (base64UrlStr.Length % 4)
            {
                case 2:
                    base64UrlStr += "==";
                    break;

                case 3:
                    base64UrlStr += "=";
                    break;
            }
            byte[] bytes = Convert.FromBase64String(base64UrlStr);

            return Encoding.UTF8.GetString(bytes);
        }

        /// <summary>
        /// 将Json字符串反序列化为对象
        /// </summary>
        /// <typeparam name="TEntity">对象类型</typeparam>
        /// <param name="jsonStr">Json字符串</param>
        /// <returns></returns>
        public static TEntity ToObject<TEntity>(this string jsonStr)
        {
            return JsonSerializer.Deserialize<TEntity>(jsonStr);
        }

        public static dynamic DeserializeDynamicJsonObject(this string data)
        {
            return new JsonTextAccessor(JsonSerializer.Deserialize<JsonElement>(data));
        }
    }

    public class JsonTextAccessor : DynamicObject
    {
        private readonly JsonElement _content;
        public JsonTextAccessor(JsonElement content)
        {
            _content = content;
        }
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = null;
            if (_content.TryGetProperty(binder.Name, out JsonElement value))
            {
                result = Obtain(value);
            }
            else
            {
                return false;
            }
            return true;
        }
        private Object? Obtain(in JsonElement element)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.String: return element.GetString();
                case JsonValueKind.Null: return null;
                case JsonValueKind.False: return false;
                case JsonValueKind.True: return true;
                case JsonValueKind.Number: return element.GetDouble();
                default: break;
            }

            if (element.ValueKind == JsonValueKind.Array)
            {
                var list = new List<object>();
                foreach (var item in element.EnumerateArray())
                {
                    list.Add(item);
                }
                return list;
            }
            else
            {
                return new JsonTextAccessor(element);
            }
        }
    }
}