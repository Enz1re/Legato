using Ninject;
using System.Web.Http;
using Newtonsoft.Json;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Controllers
{
    public class ClassicalController : ApiController
    {
        private ILegatoServiceWorker _serviceWorker;

        [Inject]
        public ClassicalController(ILegatoServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        [GuitarFilter]
        [Route("api/Classical/{lowerBound}/{upperBound}")]
        public IHttpActionResult Get([FromUri]string filterJson, int lowerBound, int upperBound)
        {
            var filter = JsonConvert.DeserializeObject<FilterViewModel>(filterJson);

            return Ok(_serviceWorker.GetAcousticClassicalGuitars(filter, lowerBound, upperBound));
        }

        [Route("api/Classical/Vendors")]
        public IHttpActionResult GetVendors()
        {
            return Ok(_serviceWorker.GetAcousticClassicalGuitarVendors());
        }

        [Route("api/Classical/Quantity")]
        public IHttpActionResult GetQuantity()
        {
            return Ok(_serviceWorker.GetAcousticClassicalGuitarAmount());
        }
    }
}