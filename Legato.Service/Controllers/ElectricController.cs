using System.Web.Http;
using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Controllers
{
    public class ElectricController : ApiController
    {
        private ILegatoServiceWorker _serviceWorker;

        public ElectricController(ILegatoServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        public IEnumerable<ElectricGuitarViewModel> Get()
        {
            return _serviceWorker.GetAllElectricGuitars();
        }

        [Route("api/Electric/Vendors")]
        public IEnumerable<string> GetVendors()
        {
            return _serviceWorker.GetElectricGuitarVendors();
        }

        [Route("api/Electric/{vendor}")]
        public IEnumerable<ElectricGuitarViewModel> Get(string vendor)
        {
            return _serviceWorker.GetElectricGuitarsByVendor(vendor);
        }

        [Route("api/Electric/{from}/{to}")]
        public IEnumerable<ElectricGuitarViewModel> Get(short from, short to)
        {
            return _serviceWorker.GetElectricGuitarsByPrice(from, to);
        }
    }
}