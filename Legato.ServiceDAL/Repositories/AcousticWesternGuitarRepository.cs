using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.LegatoMiddleware;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class AcousticWesternGuitarRepository : IGuitarRepository<AcousticWesternGuitarDataModel>
    {
        private LegatoMiddlewareClient _service;

        [Inject]
        public AcousticWesternGuitarRepository(LegatoMiddlewareClient service)
        {
            _service = service;
            _service.Open();
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAll()
        {
            return _service.GetAllAcousticWesternGuitars();
        }

        public IEnumerable<string> GetVendors()
        {
            return _service.GetAcousticWesternGuitarVendors();
        }

        public IEnumerable<AcousticWesternGuitarDataModel> FindByCost(short from, short to)
        {
            return _service.GetAcousticWesternGuitarsByPrice(from, to);
        }

        public IEnumerable<AcousticWesternGuitarDataModel> FindByVendor(string vendor)
        {
            return _service.GetAcousticWesternGuitarsByVendor(vendor);
        }

        public void Dispose()
        {
            _service.Close();
        }
    }
}
