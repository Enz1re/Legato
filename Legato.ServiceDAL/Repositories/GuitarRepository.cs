using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Middleware;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class GuitarRepository : IGuitarRepository<GuitarDataModel>
    {
        private LegatoMiddlewareClient _client;

        [Inject]
        public GuitarRepository(LegatoMiddlewareClient client)
        {
            _client = client;
            //_client.Open();
        }

        public IEnumerable<GuitarDataModel> GetAll()
        {
            return _client.GetAllGuitars();
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetAllVendors();
        }

        public IEnumerable<GuitarDataModel> FindByCost(short from, short to)
        {
            return _client.GetGuitarsByPrice(from, to);
        }

        public IEnumerable<GuitarDataModel> FindByVendor(string vendor)
        {
            return _client.GetGuitarsByVendor(vendor);
        }

        public void Dispose()
        {
           // _client.Close();
        }
    }
}
