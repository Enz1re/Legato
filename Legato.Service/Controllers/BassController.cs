using Ninject;
using System.Web.Http;


namespace Legato.Service.Controllers
{
    public class BassController : ApiController
    {
        private ILegatoServiceWorker _serviceWorker;

        [Inject]
        public BassController(ILegatoServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        [GuitarFilter]
        [Route("api/Bass/{lowerBound}/{upperBound}")]
        public IHttpActionResult Get(int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetAllBassGuitars(lowerBound, upperBound));
        }

        [Route("api/Bass/Vendors")]
        public IHttpActionResult GetVendors()
        {
            return Ok(_serviceWorker.GetBassGuitarVendors());
        }

        [Route("api/Bass/Quantity")]
        public IHttpActionResult GetAmount()
        {
            return Ok(_serviceWorker.GetBassGuitarAmount());
        }

        [GuitarFilter]
        [Route("api/Bass/{lowerBound}/{upperBound}")]
        public IHttpActionResult Get([FromUri]string[] vendors, int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetBassGuitarsByVendors(vendors, lowerBound, upperBound));
        }

        [GuitarFilter]
        [Route("api/Bass/{from}/{to}/{lowerBound}/{upperBound}")]
        public IHttpActionResult Get(int from, int to, int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetBassGuitarsByPrice(from, to, lowerBound, upperBound));
        }
    }
}