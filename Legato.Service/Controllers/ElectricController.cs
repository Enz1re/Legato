using Ninject;
using System.Web.Http;


namespace Legato.Service.Controllers
{
    public class ElectricController : ApiController
    {
        private ILegatoServiceWorker _serviceWorker;

        [Inject]
        public ElectricController(ILegatoServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        [GuitarFilter]
        [Route("api/Electric/{lowerBound}/{upperBound}")]
        public IHttpActionResult Get(int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetAllElectricGuitars(lowerBound, upperBound));
        }

        [Route("api/Electric/Vendors")]
        public IHttpActionResult GetVendors()
        {
            return Ok(_serviceWorker.GetElectricGuitarVendors());
        }

        [Route("api/Electric/Quantity")]
        public IHttpActionResult GetQuantity()
        {
            return Ok(_serviceWorker.GetElectricGuitarAmount());
        }

        [GuitarFilter]
        [Route("api/Electric/{vendorsString}/{lowerBound}/{upperBound}")]
        public IHttpActionResult Get(string vendorsString, int lowerBound, int upperBound)
        {
            var vendors = vendorsString.Split(',');
            return Ok(_serviceWorker.GetElectricGuitarsByVendors(vendors, lowerBound, upperBound));
        }

        [GuitarFilter]
        [Route("api/Electric/{from}/{to}/{lowerBound}/{upperBound}")]
        public IHttpActionResult Get(int from, int to, int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetElectricGuitarsByPrice(from, to, lowerBound, upperBound));
        }
    }
}