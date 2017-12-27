using System;
using Ninject;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using Legato.Service.Constants;
using Legato.Service.Interfaces;
using System.Web.Http.Controllers;


namespace Legato.Service.Filters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class LegatoAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        private readonly string _currentClaim;

        [Inject]
        public ILegatoUserServiceWorker ServiceWorker { get; set; }

        public bool AllowMultiple => false;

        public LegatoAuthorizeAttribute(string thisClaim)
        {
            _currentClaim = thisClaim;
        }

        public Task<HttpResponseMessage> ExecuteAuthorizationFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            var accessToken = actionContext.Request.Headers.Authorization?.Parameter;

            if (string.IsNullOrEmpty(accessToken))
            {
                return Task.FromResult(actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, Strings.AccessTokenIsMissing));
            }

            var principal = JwtManager.GetPrincipal(accessToken);
            if (principal == null || !ServiceWorker.IsTokenActive(accessToken))
            {
                return Task.FromResult(actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, Strings.AccessTokenIsInvalid));
            }
            if (!ServiceWorker.HasClaim(principal.Identity.Name, _currentClaim))
            {
                return Task.FromResult(actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, Strings.Unauthorized));
            }
            
            return continuation();
        }
    }
}