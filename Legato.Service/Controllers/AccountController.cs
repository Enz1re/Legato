using System.Web.Http;


namespace Legato.Service.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        private const int TokenExpiryMinutes = 40;

        [HttpPost]
        [Route("Login")]
        public IHttpActionResult Login([FromBody]dynamic creds)
        {
            var username = creds.username.Value;
            var password = creds.password.Value;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return BadRequest(Constants.Strings.UsernameAndPasswordAreRequired);
            }
            if (username.ToLower() != "admin" && password.ToLower() != "admin")
            {
                return BadRequest(Constants.Strings.UsernameIsIncorrect(username));
            }

            return Ok(new
            {
                accessToken = JwtManager.GenerateToken(username, TokenExpiryMinutes)
            });
        }
    }
}
