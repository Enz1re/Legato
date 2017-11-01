using Ninject;
using System.Web.Http;
using Legato.Service.ReturnTypes;


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

        public GuitarList Get()
        {
            return _serviceWorker.GetAllElectricGuitars();
        }

        [Route("api/Electric/Vendors")]
        public VendorList GetVendors()
        {
            return _serviceWorker.GetElectricGuitarVendors();
        }

        [Route("api/Electric/{vendor}")]
        public GuitarList Get(string vendor)
        {
            return _serviceWorker.GetElectricGuitarsByVendor(vendor);
        }

        [Route("api/Electric/{from}/{to}")]
        public GuitarList Get(short from, short to)
        {
            return _serviceWorker.GetElectricGuitarsByPrice(from, to);
        }
    }
}