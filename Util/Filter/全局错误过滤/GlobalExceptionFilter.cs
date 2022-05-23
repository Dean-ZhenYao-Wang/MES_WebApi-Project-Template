using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Util
{
    public class GlobalExceptionFilter : BaseActionFilter, IExceptionFilter
    {
        private readonly ILogger<GlobalExceptionFilter> logger;

        public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> loggers)
        {
            logger = loggers;
        }

        public void OnException(ExceptionContext context)
        {
            System.Exception ex = context.Exception;
            if (ex is DomainException domainEx)
            {
                logger.LogInformation(ex, $"系统跟踪:\r\t领域异常：\r\t{domainEx.Message}");
                context.Result = Error(domainEx.Message, domainEx.ErrorCode);
            }
            else if (ex is BusinessException businessEx)
            {
                logger.LogInformation(ex, $"系统跟踪:\r\t业务异常：\r\t{businessEx.Message}");
                context.Result = Error(businessEx.Message, businessEx.ErrorCode);
            }
            else
            {
                logger.LogError(ex, $"系统跟踪:\r\t系统异常：\r\t{ex.Message}");
                context.Result = Error(ex.Message);
                if (ex.InnerException != null)
                {
                    logger.LogError(ex, $"系统跟踪:\r\t内部异常：\r\t{ex.InnerException.Message}");
                    context.Result = Error(ex.InnerException.Message);
                }
            }
        }
    }
}