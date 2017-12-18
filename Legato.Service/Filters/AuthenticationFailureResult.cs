using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http.Formatting;


namespace Legato.Service.Filters
{
    public class AuthenticationFailureResult : IHttpActionResult
    {
        public object JsonContent { get; }

        public HttpRequestMessage Request { get; }

        public AuthenticationFailureResult(string message, HttpRequestMessage request)
        {
            JsonContent = new { Error = true, Message = message };
            Request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute());
        }

        private HttpResponseMessage Execute()
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Unauthorized)
            {
                RequestMessage = Request,
                Content = new ObjectContent(JsonContent.GetType(), JsonContent, new JsonMediaTypeFormatter())
            };

            return response;
        }
    }
}