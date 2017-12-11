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

        public void Add(ElectricGuitarDataModel guitar)
        {
            _client.AddElectricGuitar(guitar);
        }

        public void Update(ElectricGuitarDataModel guitar)
        {
            _client.EditElectricGuitar(guitar);
        }

        public void Delete(int id)
        {
            _client.RemoveElectricGuitar(id);
        }

        public IEnumerable<ElectricGuitarDataModel> Get(FilterDataModel filter, int lowerBound, int upperBound)
        {
            return _client.GetElectricGuitars(filter, lowerBound, upperBound);
        }

        public IEnumerable<ElectricGuitarDataModel> GetSorted(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            return _client.GetSortedElectricGuitars(filter, lowerBound, upperBound, sorting);
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetElectricGuitarVendors();
        }
        
        public int GetAmount(FilterDataModel filter)
        {
            return _client.GetElectricGuitarQuantity(filter);
        }
    }
}
