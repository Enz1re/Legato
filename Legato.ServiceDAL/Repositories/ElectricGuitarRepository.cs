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

        public IEnumerable<ElectricGuitarDataModel> GetAll(int lowerBound, int upperBound)
        {
            return _client.GetAllElectricGuitars(lowerBound, upperBound);
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetElectricGuitarVendors();
        }
        
        public int GetAmount()
        {
            return _client.GetElectricGuitarQuantity();
        }

        public IEnumerable<ElectricGuitarDataModel> FindByCost(int from, int to, int lowerBound, int upperBound)
        {
            return _client.GetElectricGuitarsByPrice(from, to, lowerBound, upperBound);
        }

        public IEnumerable<ElectricGuitarDataModel> FindByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            return _client.GetElectricGuitarsByVendors(vendors, lowerBound, upperBound);
        }
    }
}
