using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Util
{
    /// <summary>
    ///  HttpContex帮助类
    /// </summary>
    public class HttpContextHelper<T> : IMiddleware
    {
        /// <summary>
        /// 当前登录用户信息，jwt中的信息
        /// 默认使用属性名Key当作用户的guid
        /// </summary>
        public static T CurrentLoginUser;

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            HttpRequest req = context.Request;
            string token = req.GetLoginToken();
            CurrentLoginUser = JWTHelper.GetPayload<T>(token);

            await next(context);
        }
    }
}