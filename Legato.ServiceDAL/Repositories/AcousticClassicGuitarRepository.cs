using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.Middleware;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class AcousticClassicalGuitarRepository : IGuitarRepository<AcousticClassicalGuitarDataModel>
    {
        private LegatoMiddlewareClient _client;

        [Inject]
        public AcousticClassicalGuitarRepository(LegatoMiddlewareClient client)
        {
            _client = client;
        }

        public void Add(AcousticClassicalGuitarDataModel guitar)
        {
            _client.AddAcousticClassicalGuitar(guitar);
        }

        public void Update(AcousticClassicalGuitarDataModel guitar)
        {
            _client.EditAcousticClassicalGuitar(guitar);
        }

        public void Delete(AcousticClassicalGuitarDataModel guitar)
        {
            _client.RemoveAcousticClassicalGuitar(guitar);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> Get(FilterDataModel filter, int lowerBound, int upperBound)
        {
            return _client.GetAcousticClassicalGuitars(filter, lowerBound, upperBound);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetSorted(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            return _client.GetSortedAcousticClassicalGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public IEnumerable<string> GetVendors()
        {
            return _client.GetAcousticClassicalGuitarVendors();
        }

        public int GetAmount(FilterDataModel filter)
        {
            return _client.GetAcousticClassicalGuitarQuantity(filter);
        }
    }
}
