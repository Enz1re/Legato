using System.Web.Http;


namespace Legato.Service.Extensions
{
    public static class ControllerExtensions
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