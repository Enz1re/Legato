using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.LegatoMiddleware;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class AcousticClassicalGuitarRepository : IGuitarRepository<AcousticClassicalGuitarDataModel>
    {
        private LegatoMiddlewareClient _service;

        [Inject]
        public AcousticClassicalGuitarRepository(LegatoMiddlewareClient service)
        {
            _service = service;
            _service.Open();
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAll()
        {
            return _service.GetAllAcousticClassicalGuitars();
        }

        public IEnumerable<string> GetVendors()
        {
            return _service.GetAcousticClassicalGuitarVendors();
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> FindByCost(short from, short to)
        {
            return _service.GetAcousticClassicalGuitarsByPrice(from, to);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> FindByVendor(string vendor)
        {
            return _service.GetAcousticClassicalGuitarsByVendor(vendor);
        }

        public void Dispose()
        {
            _service.Close();
        }
    }
}
