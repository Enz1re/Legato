using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.Middleware;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class ElectricGuitarRepository : IGuitarRepository<ElectricGuitarDataModel>
    {
        private LegatoMiddlewareClient _client;

        [Inject]
        public ElectricGuitarRepository(LegatoMiddlewareClient client)
        {
            _client = client;
        }

        public IEnumerable<ElectricGuitarDataModel> GetAll()
        {
            return _client.GetAllElectricGuitars();
        }

        public IEnumerable<VendorDataModel> GetVendors()
        {
            return _client.GetElectricGuitarVendors();
        }
        
        public IEnumerable<ElectricGuitarDataModel> FindByCost(short from, short to)
        {
            return _client.GetElectricGuitarsByPrice(from, to);
        }

        public IEnumerable<ElectricGuitarDataModel> FindByVendor(string vendor)
        {
            return _client.GetElectricGuitarsByVendor(vendor);
        }
    }
}
