using System.Web.Http;
using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Controllers
{
    public class ElectroController : ApiController
    {
        private ILegatoServiceWorker _serviceWorker;

        public ElectroController(ILegatoServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        public IEnumerable<ElectroGuitarViewModel> Get()
        {
            return _serviceWorker.GetAllElectroGuitars();
        }

        public IEnumerable<ElectroGuitarViewModel> Get(string vendor)
        {
            return _serviceWorker.GetElectroGuitarsByVendor(vendor);
        }

        public IEnumerable<ElectroGuitarViewModel> Get(short from, short to)
        {
            return _serviceWorker.GetElectroGuitarsByPrice(from, to);
        }
    }
}