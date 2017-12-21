using System;
using Ninject;
using System.Web.Http;
using Legato.Service.Filters;
using Legato.Service.Constants;
using Legato.Service.Interfaces;


namespace Legato.Service.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        // set default token expiry to one day
        private const int TokenExpiryMinutes = 60 * 24;
        private ILegatoUserServiceWorker _serviceWorker;

        [Inject]
        public AccountController(ILegatoUserServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
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

            var userClaims = _serviceWorker.GetClaims(username);
            var userRole = _serviceWorker.GetUserRole(username);
            var accessToken = JwtManager.GenerateToken(username, userRole, userClaims.UserClaims, TokenExpiryMinutes);

            if (!_serviceWorker.AddToken(accessToken, TokenExpiryMinutes))
            {
                return InternalServerError(new Exception(Strings.FailedToIssueToken));
            }

            return Ok(new { accessToken = accessToken });
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
            if (!_serviceWorker.IsTokenActive(accessToken) || !_serviceWorker.RemoveToken(accessToken))
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
            var accessToken = Request.Headers.Authorization?.Parameter;

            if (string.IsNullOrEmpty(accessToken) || string.IsNullOrEmpty(username))
            {
                return BadRequest(Strings.AccessTokenIsMissing);
            }
            if (!_serviceWorker.IsTokenActive(accessToken))
            {
                return BadRequest(Strings.AccessTokenIsInvalid);
            }
            if (_serviceWorker.IsTokenBanned(accessToken))
            {
                return BadRequest(Strings.AccessTokenIsAlreadyBanned);
            }
            if (!_serviceWorker.BanToken(accessToken))
            {
                return InternalServerError(new Exception(Strings.FailedToBlockUser(username)));
            }

            return Ok();
        }

        [HttpGet]
        [Route("Users")]
        [LegatoAuthentication]
        [LegatoAuthorize(Strings.GetListOfUsers)]
        public IHttpActionResult GetUsers()
        {

        }
    }
}
