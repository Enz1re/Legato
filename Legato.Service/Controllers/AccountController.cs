using System.Web.Http;


namespace Legato.Service.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        private const int TokenExpiryMinutes = 40;

        public AccountController()
        {
        }

        [HttpPost]
        [Route("Login")]
        public IHttpActionResult Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return BadRequest(Constants.Strings.UsernameAndPasswordAreRequired);
            }
            if (username.ToLower() != "admin" && password.ToLower() != "admin")
            {
                return BadRequest(Constants.Strings.UsernameIsIncorrect(username));
            }

            return Ok(JwtManager.GenerateToken(username, TokenExpiryMinutes));
        }
    }
}
