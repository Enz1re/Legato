using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Middleware;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class ElectroGuitarRepository : IGuitarRepository<ElectroGuitarDataModel>
    {
        private LegatoMiddlewareClient _client;

        [Inject]
        public ElectroGuitarRepository(LegatoMiddlewareClient client)
        {
            _client = client;
            _client.Open();
        }

        public IEnumerable<ElectroGuitarDataModel> GetAll()
        {
            return _client.GetAllElectroGuitars();
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetElectricGuitarVendors();
        }
        
        public IEnumerable<ElectroGuitarDataModel> FindByCost(short from, short to)
        {
            return _client.GetElectroGuitarsByPrice(from, to);
        }

        public IEnumerable<ElectroGuitarDataModel> FindByVendor(string vendor)
        {
            return _client.GetElectroGuitarsByVendor(vendor);
        }

        public void Dispose()
        {
            _client.Close();
        }
    }
}
