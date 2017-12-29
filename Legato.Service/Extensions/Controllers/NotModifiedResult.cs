namespace Legato.Service.Extensions.Controllers
{
    using System.Net;
    using System.Web.Http;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class NotModifiedResult : IHttpActionResult
    {
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotModified));
        }
    }
}