using Newtonsoft.Json.Linq;

namespace Util
{
    // <summary>
    /// JWT帮助类
    /// </summary>
    public static class JWTHelper
    {
        /// <summary>
        /// 校验密钥
        /// </summary>
        public static readonly string secret = ConfigHelper.GetValue("JWTSecret");

        private static readonly string _headerBase64Url = "{\"alg\":\"HS256\",\"typ\":\"JWT\"}".Base64UrlEncode();

        /// <summary>
        /// 生成Token
        /// </summary>
        /// <param name="payloadJsonStr">数据JSON字符串</param>
        /// <returns></returns>
        public static string GetToken(string payloadJsonStr)
        {
            string payloadBase64Url = payloadJsonStr.Base64UrlEncode();
            string sign = $"{_headerBase64Url}.{payloadBase64Url}".ToHMACSHA256String(secret);

            return $"{_headerBase64Url}.{payloadBase64Url}.{sign}";
        }

        /// <summary>
        /// 获取Token中的数据
        /// </summary>
        /// <typeparam name="TEntity">泛型</typeparam>
        /// <param name="token">token</param>
        /// <returns></returns>
        public static TEntity GetPayload<TEntity>(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return default;
            }
            else
            {
                return token.Split('.')[1].Base64UrlDecode().ToObject<TEntity>();
            }
        }

        /// <summary>
        /// 校验Token
        /// </summary>
        /// <param name="token">token</param>
        /// <returns></returns>
        public static bool CheckToken(string token)
        {
            string[] items = token.Split('.');
            string oldSign = items[2];
            string newSign = $"{items[0]}.{items[1]}".ToHMACSHA256String(secret);

            return oldSign == newSign;
        }
    }
}