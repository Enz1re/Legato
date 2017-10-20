using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.LegatoMiddleware;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class GuitarRepository : IGuitarRepository<GuitarDataModel>
    {
        private LegatoMiddlewareClient _service;

        [Inject]
        public GuitarRepository(LegatoMiddlewareClient service)
        {
            _service = service;
        }

        public IEnumerable<GuitarDataModel> GetAll()
        {
            return _service.GetAllGuitars();
        }

        public IEnumerable<string> GetVendors()
        {
            return _service.GetAllVendors();
        }

        public IEnumerable<GuitarDataModel> FindByCost(short from, short to)
        {
            return _service.GetGuitarsByPrice(from, to);
        }

        public IEnumerable<GuitarDataModel> FindByVendor(string vendor)
        {
            return _service.GetGuitarsByVendor(vendor);
        }

        public void Dispose()
        {
            _service.Close();
        }
    }
}
