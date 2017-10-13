using Ninject;
using System.Collections.Generic;
using Legato.MiddlewareContracts;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class AcousticClassicalGuitarRepository : IGuitarRepository<AcousticClassicalGuitarDataModel>
    {
        private ILegatoMiddleware _service;

        [Inject]
        public AcousticClassicalGuitarRepository(ILegatoMiddleware service)
        {
            _service = service;
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAll()
        {
            return _service.GetAllAcousticClassicalGuitars();
        }

        public IEnumerable<string> GetVendors()
        {
            return _service.GetAcousticClassicalGuitarVendors();
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> FindByCost(short from, short to)
        {
            return _service.GetAcousticClassicalGuitarsByPrice(from, to);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> FindByVendor(string vendor)
        {
            return _service.GetAcousticClassicalGuitarsByVendor(vendor);
        }
    }
}
