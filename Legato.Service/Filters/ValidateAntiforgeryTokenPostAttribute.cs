﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using System.Net.Http.Headers;
using Legato.Service.Constants;


namespace Legato.Service.Filters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class ValidateAntiforgeryTokenPostAttribute : Attribute, IAuthenticationFilter
    {
        public bool AllowMultiple => false;

        public Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            var serializedRequest = context.Request.Content.ReadAsStringAsync().Result;
            string antiforgeryToken = Serialization.Deserialize<dynamic>(serializedRequest).antiforgeryToken;

            if (antiforgeryToken == null)
            {
                context.ErrorResult = new AuthenticationFailureResult(Strings.AntiforgeryTokenIsMissing, context.ActionContext.Request);
                return Task.FromResult(0);
            }
            if (!Antiforgery.ValidateToken("antiforgeryTokenPost", antiforgeryToken))
            {
                context.ErrorResult = new AuthenticationFailureResult(Strings.AntiforgeryTokenIsMissing, context.ActionContext.Request);
                return Task.FromResult(0);
            }

            return Task.FromResult(antiforgeryToken);
        }

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            var challenge = new AuthenticationHeaderValue("Bearer");
            context.Result = new AddChallengeOnUnauthorizedResult(challenge, context.Result);
            return Task.FromResult(0);
        }
    }
}