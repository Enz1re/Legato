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

        [Route("api/Classical/Vendors")]
        public IEnumerable<string> GetVendors()
        {
            return _serviceWorker.GetAcousticClassicalGuitarVendors();
        }

        [Route("api/Classical/{vendor}")]
        public IEnumerable<AcousticClassicalGuitarViewModel> Get(string vendor)
        {
            return _serviceWorker.GetAcousticClassicalGuitarsByVendor(vendor);
        }

        [Route("api/Classical/{from}/{to}")]
        public IEnumerable<AcousticClassicalGuitarViewModel> Get(short from, short to)
        {
            return _serviceWorker.GetAcousticClassicalGuitarsByPrice(from, to);
        }

        public new void Dispose()
        {
            base.Dispose();
            _serviceWorker.Dispose();
        }
    }
}