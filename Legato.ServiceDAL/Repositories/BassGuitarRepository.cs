using Ninject;
using System.Collections.Generic;
using Legato.MiddlewareContracts;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class BassGuitarRepository : IGuitarRepository<BassGuitarDataModel>
    {
        private ILegatoMiddleware _service;

        [Inject]
        public BassGuitarRepository(ILegatoMiddleware service)
        {
            _service = service;
        }

        public IEnumerable<BassGuitarDataModel> GetAll()
        {
            return _service.GetAllBassGuitars();
        }

        public IEnumerable<string> GetVendors()
        {
            return _service.GetElectricGuitarVendors();
        }

        public IEnumerable<BassGuitarDataModel> FindByCost(short from, short to)
        {
            return _service.GetBassGuitarsByPrice(from, to);
        }

        public IEnumerable<BassGuitarDataModel> FindByVendor(string vendor)
        {
            return _service.GetBassGuitarsByVendor(vendor);
        }
    }
}
