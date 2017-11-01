using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;
using System.Web.Http.Controllers;


namespace Legato.Service
{
    [AttributeUsage(AttributeTargets.Method)]
    public class GuitarFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var requestParams = actionContext.ActionArguments;
            bool hasLowerBound = requestParams.ContainsKey("lowerBound");
            bool hasUpperBound = requestParams.ContainsKey("upperBound");

            if (!hasLowerBound && hasUpperBound)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Lower bound must be present.");
            }
            else if (hasLowerBound && !hasUpperBound)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Upper bound must be present.");
            }
            else if (hasLowerBound && hasUpperBound && (int)requestParams["lowerBound"] > (int)requestParams["upperBound"])
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Lower bound must be less or equal than upper bound.");
            }
        }
    }
}