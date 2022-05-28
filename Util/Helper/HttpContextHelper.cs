using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;

namespace Util
{
    /// <summary>
    ///  HttpContex帮助类
    /// </summary>
    public class HttpContextHelper : IMiddleware
    {
        /// <summary>
        /// 当前登录用户信息，jwt中的信息
        /// 默认使用属性名Key当作用户的guid
        /// </summary>
        public static dynamic CurrentLoginUser { get; set; }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (context.User.Claims.Any())
            {
                CurrentLoginUser = context.User.Claims
                        .FirstOrDefault(m => m.Type.Equals("currentLoginUser"))
                        .Value.DeserializeDynamicJsonObject();
            }

            await next(context);
        }
    }
}