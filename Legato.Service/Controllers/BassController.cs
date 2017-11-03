using Ninject;
using System.Web.Http;
using Legato.ServiceDAL.ViewModels;


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
        public IHttpActionResult Get(FilterViewModel filter, int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetBassGuitars(filter, lowerBound, upperBound));
        }

        [Route("api/Bass/Vendors")]
        public IHttpActionResult GetVendors()
        {
            return Ok(_serviceWorker.GetBassGuitarVendors());
        }

        [Route("api/Bass/Quantity")]
        public IHttpActionResult GetQuantity()
        {
            return Ok(_serviceWorker.GetBassGuitarAmount());
        }
    }
}