using Microsoft.AspNetCore.Http;
using System;
using System.Text.RegularExpressions;

namespace Util
{
    /// <summary>
    /// 拓展类
    /// </summary>
    public static partial class Extention
    {
        /// <summary>
        /// 判断是否为AJAX请求
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public static bool IsAjaxRequest(this HttpRequest req)
        {
            bool result = false;

            bool xreq = req.Headers.ContainsKey("x-requested-with");
            if (xreq)
            {
                result = req.Headers["x-requested-with"] == "XMLHttpRequest";
            }

            return result;
        }

        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="req">请求</param>
        /// <returns></returns>
        public static string GetToken(this HttpRequest req)
        {
            string tokenHeader = req.Headers["Authorization"].ToString();
            if (string.IsNullOrWhiteSpace(tokenHeader))
            {
                throw new Exception("缺少token!");
            }

            string pattern = "^Bearer (.*?)$";
            if (!Regex.IsMatch(tokenHeader, pattern))
            {
                throw new Exception("token格式不对!格式为:Bearer {token}");
            }

            string token = Regex.Match(tokenHeader, pattern).Groups[1]?.ToString();
            if (string.IsNullOrWhiteSpace(token))
            {
                throw new Exception("token不能为空!");
            }

            return token;
        }

        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="req">请求</param>
        /// <returns></returns>
        public static string GetLoginToken(this HttpRequest req)
        {
            string tokenHeader = req.Headers["Authorization"].ToString();

            string pattern = "^Bearer (.*?)$";

            string token = Regex.Match(tokenHeader, pattern).Groups[1]?.ToString();

            return token;
        }

        /// <summary>
        /// 获取Token中的Payload
        /// </summary>
        /// <param name="req">请求</param>
        /// <returns></returns>
        public static TEntity GetJWTPayload<TEntity>(this HttpRequest req)
        {
            string token = req.GetToken();
            TEntity payload = JWTHelper.GetPayload<TEntity>(token);

            return payload;
        }
    }
}