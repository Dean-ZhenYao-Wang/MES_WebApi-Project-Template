using Microsoft.AspNetCore.Builder;

namespace Util.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseHttpContextHelperMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpContextHelper>();
        }
    }
}