using System.Web.Http;
using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Controllers
{
    public class ClassicalController : ApiController
    {
        private ILegatoServiceWorker _serviceWorker;

        public ClassicalController(ILegatoServiceWorker serviceWorker)
        {
            _serviceWorker = serviceWorker;
        }

        public IEnumerable<AcousticClassicalGuitarViewModel> Get()
        {
            return _serviceWorker.GetAllAcousticClassicalGuitars();
        }

        public IEnumerable<AcousticClassicalGuitarViewModel> Get(string vendor)
        {
            return _serviceWorker.GetAcousticClassicalGuitarsByVendor(vendor);
        }

        public IEnumerable<AcousticClassicalGuitarViewModel> Get(short from, short to)
        {
            return _serviceWorker.GetAcousticClassicalGuitarsByPrice(from, to);
        }
    }
}