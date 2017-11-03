using Ninject;
using System.Web.Http;
using Legato.ServiceDAL.ViewModels;


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
        public IHttpActionResult Get(FilterViewModel filter, int lowerBound, int upperBound)
        {
            return Ok(_serviceWorker.GetElectricGuitars(filter, lowerBound, upperBound));
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
    }
}