using System;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Web.Http.Filters;
using Legato.Service.Constants;
using System.Web.Http.Controllers;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.Service
{
    [AttributeUsage(AttributeTargets.Method)]
    public class GuitarFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            ValidateSerializedJsonString(actionContext, "filterJson");
            ValidateSerializedJsonString(actionContext, "sortingJson");
            ValidateRequestBounds(actionContext);
            ValidateSorting(actionContext);
        }

        private void ValidateRequestBounds(HttpActionContext actionContext)
        {
            var requestParams = actionContext.ActionArguments;
            bool hasLowerBound = requestParams.ContainsKey("lowerBound");
            bool hasUpperBound = requestParams.ContainsKey("upperBound");

            if (!hasLowerBound && hasUpperBound)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, Strings.LowerBoundMustBePresent);
            }
            else if (hasLowerBound && !hasUpperBound)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, Strings.UpperBoundMustBePresent);
            }
            else if (hasLowerBound && hasUpperBound && (int)requestParams["lowerBound"] > (int)requestParams["upperBound"])
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, Strings.LowerBoundMustBeLessOrEqual);
            }
        }

        private void ValidateSorting(HttpActionContext actionContext)
        {
            var requestParams = actionContext.ActionArguments;
            bool hasSortHeader = requestParams.ContainsKey("sortHeader");
            bool hasSortDirection = requestParams.ContainsKey("sortDirection");

            if (!hasSortHeader && !hasSortDirection)
            {
                return;
            }
            if ((!hasSortHeader && hasSortDirection) || (hasSortHeader && !hasSortDirection))
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, Strings.SortingParamsInvalid);
            }
            if (!Enum.GetNames(typeof(SortHeader)).Contains(requestParams["sortHeader"]))
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, Strings.SortHeaderIsInvalid);
            }
            if (!Enum.GetNames(typeof(SortDirection)).Contains(requestParams["sortDirection"]))
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, Strings.SortDirectionIsInvalid);
            }
        }

        private void ValidateSerializedJsonString(HttpActionContext actionContext, string paramName)
        {
            var requestParams = actionContext.ActionArguments;
            if (!requestParams.ContainsKey(paramName))
            {
                return;
            }

            string jsonString = requestParams[paramName].ToString();

            try
            {
                var json = JObject.Parse(jsonString);
            }
            catch (JsonReaderException)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, Strings.FilterStringIsInvalid);
            }
        }
    }
}