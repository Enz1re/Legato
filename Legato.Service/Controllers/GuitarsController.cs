using Ninject;
using System.Web.Http;
using System.Collections.Generic;
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

        public IEnumerable<GuitarViewModel> Get()
        {
            return _serviceWorker.GetAllGuitars();
        }

        [Route("api/Guitars/Vendors")]
        public IEnumerable<string> GetVendors()
        {
            return _serviceWorker.GetAllVendors();
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