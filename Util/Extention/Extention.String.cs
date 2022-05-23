using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Security.Cryptography;
using System.Text;

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

        // <summary>
        /// 将Json字符串转为JObject
        /// </summary>
        /// <param name="jsonStr">Json字符串</param>
        /// <returns></returns>
        public static JObject ToJObject(this string jsonStr)
        {
            return jsonStr == null ? JObject.Parse("{}") : JObject.Parse(jsonStr.Replace("&nbsp;", ""));
        }

        /// <summary>
        /// 将Json字符串反序列化为对象
        /// </summary>
        /// <typeparam name="TEntity">对象类型</typeparam>
        /// <param name="jsonStr">Json字符串</param>
        /// <returns></returns>
        public static TEntity ToObject<TEntity>(this string jsonStr)
        {
            return JsonConvert.DeserializeObject<TEntity>(jsonStr);
        }
    }
}