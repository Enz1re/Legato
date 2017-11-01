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

        public IEnumerable<BassGuitarDataModel> GetAll()
        {
            return _client.GetAllBassGuitars();
        }

        public IEnumerable<VendorDataModel> GetVendors()
        {
            return _client.GetBassGuitarVendors();
        }

        public IEnumerable<BassGuitarDataModel> FindByCost(short from, short to)
        {
            return _client.GetBassGuitarsByPrice(from, to);
        }

        public IEnumerable<BassGuitarDataModel> FindByVendor(string vendor)
        {
            return _client.GetBassGuitarsByVendor(vendor);
        }
    }
}
