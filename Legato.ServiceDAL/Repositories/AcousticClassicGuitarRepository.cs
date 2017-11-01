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

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAll(int lowerBound, int upperBound)
        {
            return _client.GetAllAcousticClassicalGuitars(lowerBound, upperBound);
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetAcousticClassicalGuitarVendors();
        }

        public int GetAmount()
        {
            return _client.GetAcousticClassicalGuitarQuantity();
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> FindByCost(int from, int to, int lowerBound, int upperBound)
        {
            return _client.GetAcousticClassicalGuitarsByPrice(from, to, lowerBound, upperBound);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> FindByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            return _client.GetAcousticClassicalGuitarsByVendors(vendors, lowerBound, upperBound);
        }
    }
}
