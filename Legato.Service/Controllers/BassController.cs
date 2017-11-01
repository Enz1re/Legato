using Ninject;
using System.Web.Http;
using Legato.Service.ReturnTypes;


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

        public GuitarList Get()
        {
            return _serviceWorker.GetAllBassGuitars();
        }

        [Route("api/Bass/Vendors")]
        public VendorList GetVendors()
        {
            return _serviceWorker.GetBassGuitarVendors();
        }

        [Route("api/Bass/{vendor}")]
        public GuitarList Get(string vendor)
        {
            return _serviceWorker.GetBassGuitarsByVendor(vendor);
        }

        [Route("api/Bass/{from}/{to}")]
        public GuitarList Get(short from, short to)
        {
            return _serviceWorker.GetBassGuitarsByPrice(from, to);
        }
    }
}