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

        public IEnumerable<ElectroGuitarViewModel> Get()
        {
            return _serviceWorker.GetAllElectroGuitars();
        }

        [Route("api/Electric/Vendors")]
        public IEnumerable<string> GetVendors()
        {
            return _serviceWorker.GetElectricGuitarVendors();
        }

        [Route("api/Electric/{vendor}")]
        public IEnumerable<ElectroGuitarViewModel> Get(string vendor)
        {
            return _serviceWorker.GetElectroGuitarsByVendor(vendor);
        }

        [Route("api/Electric/{from}/{to}")]
        public IEnumerable<ElectroGuitarViewModel> Get(short from, short to)
        {
            return _serviceWorker.GetElectroGuitarsByPrice(from, to);
        }
    }
}