using Ninject;
using System.Web.Http;


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
        public IHttpActionResult Get(int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetAllAcousticClassicalGuitars(lowerBound, upperBound));
        }

        [Route("api/Classical/Vendors")]
        public IHttpActionResult GetVendors()
        {
            return Ok(_serviceWorker.GetAcousticClassicalGuitarVendors());
        }

        [Route("api/Classical/Quantity")]
        public IHttpActionResult GetAmount()
        {
            return Ok(_serviceWorker.GetAcousticClassicalGuitarAmount());
        }

        [GuitarFilter]
        [Route("api/Classical/{lowerBound}/{upperBound}")]
        public IHttpActionResult Get([FromUri]string[] vendors, int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetAcousticClassicalGuitarsByVendors(vendors, lowerBound, upperBound));
        }

        [GuitarFilter]
        [Route("api/Classical/{from}/{to}/{lowerBound}/{upperBound}")]
        public IHttpActionResult Get(int from, int to, int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetAcousticClassicalGuitarsByPrice(from, to, lowerBound, upperBound));
        }
    }
}