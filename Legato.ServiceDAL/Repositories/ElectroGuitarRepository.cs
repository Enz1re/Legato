using Ninject;
using System.Collections.Generic;
using Legato.MiddlewareContracts;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class ElectroGuitarRepository : IGuitarRepository<ElectroGuitarDataModel>
    {
        private ILegatoMiddleware _service;

        [Inject]
        public ElectroGuitarRepository(ILegatoMiddleware service)
        {
            _service = service;
        }

        public IEnumerable<ElectroGuitarDataModel> FindByCost(short from, short to)
        {
            return _service.GetElectroGuitarsByPrice(from, to);
        }

        public IEnumerable<ElectroGuitarDataModel> FindByVendor(string vendor)
        {
            return _service.GetElectroGuitarsByVendor(vendor);
        }

        public IEnumerable<ElectroGuitarDataModel> GetAll()
        {
            return _service.GetAllElectroGuitars();
        }
    }
}
