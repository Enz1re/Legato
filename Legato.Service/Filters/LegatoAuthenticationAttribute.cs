using System;
using Ninject;
using System.Web;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using System.Net.Http.Headers;
using Legato.Service.Constants;
using Legato.Service.Interfaces;
using System.Web.Http.Controllers;
using System.ServiceModel.Channels;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Filters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class LegatoAuthenticationAttribute : Attribute, IAuthenticationFilter
    {
        private const string Context = "MS_HttpContext";

        [Inject]
        public ILegatoUserServiceWorker ServiceWorker { get; set; }

        public bool AllowMultiple => false;

        public Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            if (context.ActionContext.Request.Headers.Authorization?.Scheme != "Bearer")
            {
                context.ErrorResult = new AuthenticationFailureResult(Strings.AuthSchemeIsInvalid, context.ActionContext.Request);
                return Task.FromResult(0);
            }

            var token = context.ActionContext.Request.Headers.Authorization?.Parameter;
            if (string.IsNullOrEmpty(token))
            {
                context.ErrorResult = new AuthenticationFailureResult(Strings.AccessTokenIsMissing, context.ActionContext.Request);
                return Task.FromResult(0);
            }
            if (ServiceWorker.IsTokenBanned(token))
            {
                NotifyCompromisedAttempt(token, context.ActionContext);
                context.ErrorResult = new AuthenticationFailureResult(Strings.AccessTokenIsBanned, context.ActionContext.Request);
                return Task.FromResult(0);
            }
            if (!ServiceWorker.IsTokenActive(token))
            {
                context.ErrorResult = new AuthenticationFailureResult(Strings.AccessTokenIsInvalid, context.ActionContext.Request);
                return Task.FromResult(0);
            }
            
            var principal = JwtManager.GetPrincipal(token);

            if (principal == null || !ServiceWorker.GetUserManager().FindUser(principal.Identity.Name))
            {
                context.ErrorResult = new AuthenticationFailureResult(Strings.AccessTokenIsInvalid, context.ActionContext.Request);
                return Task.FromResult(0);
            }

            return Task.FromResult(principal);
        }

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            var challenge = new AuthenticationHeaderValue("Bearer");
            context.Result = new AddChallengeOnUnauthorizedResult(challenge, context.Result);
            return Task.FromResult(0);
        }

        private void NotifyCompromisedAttempt(string accessToken, HttpActionContext actionContext)
        {
            var requestIP = GetRequestIP(actionContext.Request);
            var principalName = JwtManager.GetPrincipal(accessToken).Identity.Name;
            var dateTime = DateTime.UtcNow;

            Task.Factory.StartNew(() =>
            {
                ServiceWorker.AddCompromisedAttempt(new CompromisedAttemptViewModel
                {
                    CompromisedToken = accessToken,
                    RequestIP = requestIP,
                    Username = principalName,
                    RequestDateTime = dateTime
                });
            });
        }

        private string GetRequestIP(HttpRequestMessage request)
        {
            if (HttpContext.Current != null)
            {
                return HttpContext.Current.Request.UserHostAddress;
            }
            if (request.Properties.ContainsKey(Context))
            {
                return ((HttpContextWrapper)request.Properties[Context]).Request.UserHostAddress;
            }
            if (request.Properties.ContainsKey(RemoteEndpointMessageProperty.Name))
            {
                var prop = (RemoteEndpointMessageProperty)request.Properties[RemoteEndpointMessageProperty.Name];
                return prop.Address;
            }
            else
            {
                return null;
            }
        }
    }
}