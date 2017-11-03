using Ninject;
using System.Web.Http;
using Legato.ServiceDAL.ViewModels;


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
        public IHttpActionResult Get(FilterViewModel filter, int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetAcousticWesternGuitars(filter, lowerBound, upperBound));
        }

        [Route("api/Western/Vendors")]
        public IHttpActionResult GetVendors()
        {
            return Ok(_serviceWorker.GetAcousticWesternGuitarVendors());
        }

        [Route("api/Western/Quantity")]
        public IHttpActionResult GetQuantity()
        {
            return Ok(_serviceWorker.GetAcousticWesternGuitarAmount());
        }
    }
}