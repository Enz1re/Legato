using Ninject;
using System.Web.Http;


namespace Legato.Service.Controllers
{
    public class WesternController : ApiController
    {
        private ILegatoServiceWorker _serviceWorker;

        [Inject]
        public WesternController(ILegatoServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        [GuitarFilter]
        [Route("api/Western/{lowerBound}/{upperBound}")]
        public IHttpActionResult Get(int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetAllAcousticWesternGuitars(lowerBound, upperBound));
        }

        [Route("api/Western/Vendors")]
        public IHttpActionResult GetVendors()
        {
            return Ok(_serviceWorker.GetAcousticWesternGuitarVendors());
        }

        [Route("api/Western/Quantity")]
        public IHttpActionResult GetAmount()
        {
            return Ok(_serviceWorker.GetAcousticWesternGuitarAmount());
        }

        [GuitarFilter]
        [Route("api/Western/{lowerBound}/{upperBound}")]
        public IHttpActionResult Get([FromUri]string[] vendors, int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetAcousticWesternGuitarsByVendors(vendors, lowerBound, upperBound));
        }

        [GuitarFilter]
        [Route("api/Western/{from}/{to}/{lowerBound}/{upperBound}")]
        public IHttpActionResult Get(int from, int to, int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetAcousticWesternGuitarsByPrice(from, to, lowerBound, upperBound));
        }
    }
}