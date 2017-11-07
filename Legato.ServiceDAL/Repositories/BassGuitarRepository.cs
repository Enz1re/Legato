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

        public IEnumerable<BassGuitarDataModel> Get(FilterDataModel filter, int lowerBound, int upperBound)
        {
            return _client.GetBassGuitars(filter, lowerBound, upperBound);
        }

        public IEnumerable<BassGuitarDataModel> GetSorted(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            return _client.GetSortedBassGuitars(filter, lowerBound, upperBound, sorting);
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetBassGuitarVendors();
        }

        public int GetAmount(FilterDataModel filter)
        {
            return _client.GetBassGuitarQuantity(filter);
        }
    }
}
