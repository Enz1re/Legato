using System.Web.Http;


namespace Legato.Service.Extensions.Controllers
{
    public static class Controllers
    {
        //
        // Summary:
        //     Creates a Legato.Service.Extensions.Controllers.NotModifiedResult (304 NotModified).
        //
        // Returns:
        //     An Legato.Service.Extensions.Controllers.NotModifiedResult
        public static IHttpActionResult NotModified(this ApiController controller)
        {
            return new NotModifiedResult();
        }
    }
}