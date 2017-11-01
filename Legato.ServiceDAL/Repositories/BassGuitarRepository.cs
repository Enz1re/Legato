using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Middleware;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class BassGuitarRepository : IGuitarRepository<BassGuitarDataModel>
    {
        private LegatoMiddlewareClient _client;

        [Inject]
        public BassGuitarRepository(LegatoMiddlewareClient client)
        {
            _client = client;
        }

        public IEnumerable<BassGuitarDataModel> GetAll(int lowerBound, int upperBound)
        {
            return _client.GetAllBassGuitars(lowerBound, upperBound);
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetBassGuitarVendors();
        }

        public int GetAmount()
        {
            return _client.GetBassGuitarQuantity();
        }

        public IEnumerable<BassGuitarDataModel> FindByCost(int from, int to, int lowerBound, int upperBound)
        {
            return _client.GetBassGuitarsByPrice(from, to, lowerBound, upperBound);
        }

        public IEnumerable<BassGuitarDataModel> FindByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            return _client.GetBassGuitarsByVendors(vendors, lowerBound, upperBound);
        }
    }
}
