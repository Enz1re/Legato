using Ninject;
using System.Web.Http;
using Legato.Service.ReturnTypes;


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

        public GuitarList Get()
        {
            return _serviceWorker.GetAllAcousticWesternGuitars();
        }

        [Route("api/Western/Vendors")]
        public VendorList GetVendors()
        {
            return _serviceWorker.GetAcousticWesternGuitarVendors();
        }

        [Route("api/Western/{vendor}")]
        public GuitarList Get(string vendor)
        {
            return _serviceWorker.GetAcousticWesternGuitarsByVendor(vendor);
        }

        [Route("api/Western/{from}/{to}")]
        public GuitarList Get(short from, short to)
        {
            return _serviceWorker.GetAcousticWesternGuitarsByPrice(from, to);
        }
    }
}