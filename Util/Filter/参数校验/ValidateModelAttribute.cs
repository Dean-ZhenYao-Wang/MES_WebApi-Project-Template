using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace Util
{
    public class ValidateModelAttribute : BaseActionFilter, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = Error(context.ModelState.Keys
                    .SelectMany(key => context.ModelState[key].Errors.Select(x => new ValidationError(key, x.ErrorMessage)))
                    .ToList());
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}