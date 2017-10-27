using Ninject;
using System.Web.Http;
using System.Collections.Generic;
using Legato.Service.ReturnTypes;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Controllers
{
    public class GuitarsController : ApiController
    {
        private ILegatoServiceWorker _serviceWorker;

        [Inject]
        public GuitarsController(ILegatoServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        public VendorList Get()
        {
            return new VendorList { Guitars = _serviceWorker.GetAllGuitars() };
        }

        [Route("api/Guitars/Vendors")]
        public VendorList GetVendors()
        {
            return new VendorList { Guitars = _serviceWorker.GetAllVendors() };
        }

        [Route("api/Guitars/{from}/{to}")]
        public IEnumerable<GuitarViewModel> Get(short from, short to)
        {
            return _serviceWorker.GetGuitarsByPrice(from, to);
        }

        [Route("api/Guitars/{vendor}")]
        public IEnumerable<GuitarViewModel> Get(string vendor)
        { 
            return _serviceWorker.GetGuitarsByVendor(vendor);
        }
    }
}