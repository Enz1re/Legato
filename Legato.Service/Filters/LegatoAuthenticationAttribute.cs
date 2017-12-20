using System;
using Ninject;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using System.Net.Http.Headers;
using Legato.Service.Constants;
using Legato.Service.Interfaces;


namespace Legato.Service.Filters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class LegatoAuthenticationAttribute : Attribute, IAuthenticationFilter
    {
        [Inject]
        public ILegatoUserServiceWorker ServiceWorker { get; set; }

        public bool AllowMultiple => false;

        public Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            var token = context.ActionContext.Request.Headers.Authorization?.Parameter;
            if (string.IsNullOrEmpty(token))
            {
                context.ErrorResult = new AuthenticationFailureResult(Strings.AccessTokenIsMissing, context.ActionContext.Request);
                return Task.FromResult(0);
            }

            var principal = JwtManager.GetPrincipal(token);

            if (principal == null || !ServiceWorker.FindUser(principal.Identity.Name))
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
    }
}