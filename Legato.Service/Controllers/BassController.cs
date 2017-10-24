using System.Web.Http;
using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Controllers
{
    public class BassController : ApiController
    {
        private ILegatoServiceWorker _serviceWorker;

        public BassController(ILegatoServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        public IEnumerable<BassGuitarViewModel> Get()
        {
            return _serviceWorker.GetAllBassGuitars();
        }

        [Route("api/Bass/Vendors")]
        public IEnumerable<string> GetVendors()
        {
            return _serviceWorker.GetBassGuitarVendors();
        }

        [Route("api/Bass/{vendor}")]
        public IEnumerable<BassGuitarViewModel> Get(string vendor)
        {
            return _serviceWorker.GetBassGuitarsByVendor(vendor);
        }

        [Route("api/Bass/{from}/{to}")]
        public IEnumerable<BassGuitarViewModel> Get(short from, short to)
        {
            return _serviceWorker.GetBassGuitarsByPrice(from, to);
        }
    }
}