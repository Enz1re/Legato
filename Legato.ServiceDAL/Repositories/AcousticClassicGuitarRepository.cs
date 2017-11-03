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

        public IEnumerable<AcousticClassicalGuitarDataModel> Get(FilterDataModel filter, int lowerBound, int upperBound)
        {
            return _client.GetAcousticClassicalGuitars(filter, lowerBound, upperBound);
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetAcousticClassicalGuitarVendors();
        }

        public int GetAmount()
        {
            return _client.GetAcousticClassicalGuitarQuantity();
        }
    }
}
