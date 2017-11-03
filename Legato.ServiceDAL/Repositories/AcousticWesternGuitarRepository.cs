using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Middleware;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class AcousticWesternGuitarRepository : IGuitarRepository<AcousticWesternGuitarDataModel>
    {
        private LegatoMiddlewareClient _client;

        [Inject]
        public AcousticWesternGuitarRepository(LegatoMiddlewareClient client)
        {
            _client = client;
        }

        public IEnumerable<AcousticWesternGuitarDataModel> Get(FilterDataModel filter, int lowerBound, int upperBound)
        {
            return _client.GetAcousticWesternGuitars(filter, lowerBound, upperBound);
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetAcousticWesternGuitarVendors();
        }

        public int GetAmount()
        {
            return _client.GetAcousticWesternGuitarQuantity();
        }
    }
}
