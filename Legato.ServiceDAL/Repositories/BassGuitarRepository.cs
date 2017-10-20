using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.LegatoMiddleware;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class BassGuitarRepository : IGuitarRepository<BassGuitarDataModel>
    {
        private LegatoMiddlewareClient _service;

        [Inject]
        public BassGuitarRepository(LegatoMiddlewareClient service)
        {
            _service = service;
            _service.Open();
        }

        public IEnumerable<BassGuitarDataModel> GetAll()
        {
            return _service.GetAllBassGuitars();
        }

        public IEnumerable<string> GetVendors()
        {
            return _service.GetBassGuitarVendors();
        }

        public IEnumerable<BassGuitarDataModel> FindByCost(short from, short to)
        {
            return _service.GetBassGuitarsByPrice(from, to);
        }

        public IEnumerable<BassGuitarDataModel> FindByVendor(string vendor)
        {
            return _service.GetBassGuitarsByVendor(vendor);
        }

        public void Dispose()
        {
            _service.Close();
        }
    }
}
