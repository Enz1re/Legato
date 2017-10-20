using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.LegatoMiddleware;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class ElectroGuitarRepository : IGuitarRepository<ElectroGuitarDataModel>
    {
        private LegatoMiddlewareClient _service;

        [Inject]
        public ElectroGuitarRepository(LegatoMiddlewareClient service)
        {
            _service = service;
        }

        public IEnumerable<ElectroGuitarDataModel> GetAll()
        {
            return _service.GetAllElectroGuitars();
        }

        public IEnumerable<string> GetVendors()
        {
            return _service.GetElectricGuitarVendors();
        }
        
        public IEnumerable<ElectroGuitarDataModel> FindByCost(short from, short to)
        {
            return _service.GetElectroGuitarsByPrice(from, to);
        }

        public IEnumerable<ElectroGuitarDataModel> FindByVendor(string vendor)
        {
            return _service.GetElectroGuitarsByVendor(vendor);
        }

        public void Dispose()
        {
            _service.Close();
        }
    }
}
