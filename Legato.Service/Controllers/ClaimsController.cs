using Ninject;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Headers;
using Legato.Service.Interfaces;


namespace Legato.Service.Controllers
{
    [RoutePrefix("api/Claims")]
    public class ClaimsController : ApiController
    {
        private readonly ILegatoUserServiceWorker _serviceWorker;

        [Inject]
        public ClaimsController(ILegatoUserServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        [HttpGet]
        [Route("ValidateClaim/{username}/{claimName}")]
        public IHttpActionResult ValidateUserClaim(string username, string claimName)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(claimName))
            {
                return BadRequest();
            }
            if (!_serviceWorker.FindUser(username))
            {
                return BadRequest(Constants.Strings.UsernameIsIncorrect(username));
            }

            var userClaims = _serviceWorker.GetClaims(username).UserClaims;
            if (!userClaims.Contains(claimName))
            {
                return Unauthorized(new AuthenticationHeaderValue("Bearer"));
            }

            return Ok(new { status = "Ok" });
        }
    }
}
