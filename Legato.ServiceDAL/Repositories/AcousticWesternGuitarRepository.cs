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
            _client.Open();
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAll()
        {
            return _client.GetAllAcousticWesternGuitars();
        }

        public IEnumerable<string> GetVendors()
        {
            return _client.GetAcousticWesternGuitarVendors();
        }

        public IEnumerable<AcousticWesternGuitarDataModel> FindByCost(short from, short to)
        {
            return _client.GetAcousticWesternGuitarsByPrice(from, to);
        }

        public IEnumerable<AcousticWesternGuitarDataModel> FindByVendor(string vendor)
        {
            return _client.GetAcousticWesternGuitarsByVendor(vendor);
        }

        public void Dispose()
        {
            _client.Close();
        }
    }
}
