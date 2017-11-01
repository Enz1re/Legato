using Ninject;
using System.Web.Http;
using Legato.Service.ReturnTypes;


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

        public GuitarList Get()
        {
            return _serviceWorker.GetAllAcousticClassicalGuitars();
        }

        [Route("api/Classical/Vendors")]
        public VendorList GetVendors()
        {
            return _serviceWorker.GetAcousticClassicalGuitarVendors();
        }

        [Route("api/Classical/{vendor}")]
        public GuitarList Get(string vendor)
        {
            return _serviceWorker.GetAcousticClassicalGuitarsByVendor(vendor);
        }

        [Route("api/Classical/{from}/{to}")]
        public GuitarList Get(short from, short to)
        {
            return _serviceWorker.GetAcousticClassicalGuitarsByPrice(from, to);
        }
    }
}