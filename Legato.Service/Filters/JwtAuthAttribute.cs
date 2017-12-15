using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using System.Net.Http.Headers;


namespace Legato.Service.Filters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class JwtAuthAttribute : Attribute, IAuthenticationFilter
    {
        public bool AllowMultiple => false;

        public Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            var token = context.ActionContext.Request.Headers.Authorization.Parameter;
            if (string.IsNullOrEmpty(token))
            {
                context.ErrorResult = new AuthenticationFailureResult(Constants.Strings.AccessTokenIsInvalid, context.ActionContext.Request);
                return Task.FromResult(0);
            }

            var claim = JwtManager.GetPrincipal(token);
            if (claim == null || claim.Identity.Name.ToLower() != "admin")
            {
                context.ErrorResult = new AuthenticationFailureResult(Constants.Strings.AccessTokenIsInvalid, context.ActionContext.Request);
                return Task.FromResult(0);
            }

            return Task.FromResult(claim);
        }

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            var challenge = new AuthenticationHeaderValue("Bearer");
            context.Result = new AddChallengeOnUnauthorizedResult(challenge, context.Result);
            return Task.FromResult(0);
        }
    }
}