using Ninject;
using Legato.MiddlewareContracts;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL
{
    public class GuitarUnitOfWork : IGuitarUnitOfWork
    {
        private readonly ILegatoMiddleware _service;
        private readonly IServiceRepositoryProvider _repositoryProvider;

        [Inject]
        public GuitarUnitOfWork(ILegatoMiddleware service, IServiceRepositoryProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;
            _service = service;
        }

        public IGuitarRepository<GuitarDataModel> GuitarsCommon => _repositoryProvider.GuitarRepository;

        public IGuitarRepository<AcousticClassicalGuitarDataModel> ClassicAcousticGuitars => _repositoryProvider.AcousticClassicalGuitarRepository;

        public IGuitarRepository<AcousticWesternGuitarDataModel> WesternAcousticGuitars => _repositoryProvider.AcousticWesternGuitarRepository;

        public IGuitarRepository<BassGuitarDataModel> BassGuitars => _repositoryProvider.BassGuitarRepository;

        public IGuitarRepository<ElectroGuitarDataModel> ElectricGuitars => _repositoryProvider.ElectroGuitarRepository;
    }
}
