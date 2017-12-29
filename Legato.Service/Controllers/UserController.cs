using System;
using Ninject;
using System.Web.Http;
using Legato.Service.Filters;
using Legato.Service.Constants;
using Legato.Service.Interfaces;


namespace Legato.Service.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        // set default token expiry to one day
        private const int TokenExpiryMinutes = 60 * 24;
        private ILegatoUserServiceWorker _serviceWorker;

        [Inject]
        public UserController(ILegatoUserServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        [HttpGet]
        [Route("GetAll/{lowerBound}/{upperBound}")]
        [LegatoAuthentication]
        [LegatoAuthorize(Strings.GetListOfUsers)]
        public IHttpActionResult GetUsers(int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetUsers(lowerBound, upperBound));
        }

        [HttpPost]
        [Route("Login")]
        public IHttpActionResult Login([FromBody]dynamic creds)
        {
            var username = creds.username.Value;
            var password = creds.password.Value;
            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return BadRequest(Strings.UsernameAndPasswordAreRequired);
            }
            if (!_serviceWorker.FindUser(username, password))
            {
                return BadRequest(Strings.UsernameIsIncorrect(username));
            }

            var userRole = _serviceWorker.GetUserRole(username);
            var accessToken = JwtManager.GenerateToken(username, userRole, TokenExpiryMinutes);

            if (!_serviceWorker.AddToken(accessToken, username, TokenExpiryMinutes))
            {
                return InternalServerError(new Exception(Strings.FailedToIssueToken));
            }

            return Ok(new { accessToken = accessToken, role = userRole });
        }

        [HttpGet]
        [Route("Session")]
        public IHttpActionResult GetUserSession([FromUri]string accessToken)
        {
            var principal = JwtManager.GetPrincipal(accessToken);
            if (principal == null || !_serviceWorker.IsTokenActive(accessToken))
            {
                return BadRequest(Strings.AccessTokenIsInvalid);
            }

            var username = principal.Identity.Name;
            var role = _serviceWorker.GetUserRole(username);

            return Ok(new { username = username, role = role });
        }

        [HttpPost]
        [Route("Logout")]
        public IHttpActionResult LogOut([FromBody]dynamic requestBody)
        {
            var username = requestBody.username.Value;
            var accessToken = Request.Headers.Authorization?.Parameter;

            if (string.IsNullOrEmpty(accessToken))
            {
                return BadRequest(Strings.AccessTokenIsMissing);
            }
            if (!_serviceWorker.RemoveToken(accessToken))
            {
                return InternalServerError(new Exception(Strings.FailedToLogOff));
            }

            return Ok();
        }

        [HttpPost]
        [Route("Block")]
        [LegatoAuthentication]
        [LegatoAuthorize(Strings.BlockUserClaim)]
        public IHttpActionResult BlockUser([FromBody]dynamic requestBody)
        {
            var username = requestBody.username.Value;
            if (string.IsNullOrEmpty(username))
            {
                return BadRequest(Strings.AccessTokenIsMissing);
            }

            if (!_serviceWorker.BanUser(username))
            {
                return InternalServerError(new Exception(Strings.FailedToBlockUser(username)));
            }

            return Ok();
        }

        [HttpGet]
        [Route("{username}/Claims")]
        public IHttpActionResult GetUserClaims(string username)
        {
            // TODO: return Claims object instead of array
            return Ok(_serviceWorker.GetClaims(username));
        }

        [HttpGet]
        [Route("CompromisedAttempts")]
        [LegatoAuthentication]
        [LegatoAuthorize(Strings.GetCompromisedAttempts)]
        public IHttpActionResult GetCompromisedAttempts()
        {
            return Ok(_serviceWorker.GetCompromisedAttempts());
        }

        [HttpPost]
        [Route("RemoveCompromisedAttempts")]
        [LegatoAuthentication]
        [LegatoAuthorize(Strings.RemoveCompromisedAttempts)]
        public IHttpActionResult RemoveCompromisedAttempt(dynamic request)
        {
            var compromisedAttemptsIds = request.compromisedAttempts.ToObject<int[]>();
            _serviceWorker.RemoveCompromisedAttempts(compromisedAttemptsIds);

            return Ok();
        }
    }
}
