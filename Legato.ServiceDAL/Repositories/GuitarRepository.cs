using Ninject;
using System.Collections.Generic;
using Legato.MiddlewareContracts;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class GuitarRepository : IGuitarRepository<GuitarDataModel>
    {
        private ILegatoMiddleware _service;

        [Inject]
        public GuitarRepository(ILegatoMiddleware service)
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
    }
}
