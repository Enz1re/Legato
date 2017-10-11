using Ninject;
using System.Collections.Generic;
using Legato.MiddlewareContracts;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class AcousticWesternGuitarRepository : IGuitarRepository<AcousticWesternGuitarDataModel>
    {
        private ILegatoMiddleware _service;

        [Inject]
        public AcousticWesternGuitarRepository(ILegatoMiddleware service)
        {
            _service = service;
        }

        public IEnumerable<AcousticWesternGuitarDataModel> FindByCost(short from, short to)
        {
            return _service.GetAcousticWesternGuitarsByPrice(from, to);
        }

        public IEnumerable<AcousticWesternGuitarDataModel> FindByVendor(string vendor)
        {
            return _service.GetAcousticWesternGuitarsByVendor(vendor);
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAll()
        {
            return _service.GetAllAcousticWesternGuitars();
        }
    }
}
