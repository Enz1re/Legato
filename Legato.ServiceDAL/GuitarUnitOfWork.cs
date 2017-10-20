using Ninject;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL
{
    public class GuitarUnitOfWork : IGuitarUnitOfWork
    {
        private readonly IServiceRepositoryProvider _repositoryProvider;

        [Inject]
        public GuitarUnitOfWork(IServiceRepositoryProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;
        }

        public IGuitarRepository<GuitarDataModel> GuitarsCommon => _repositoryProvider.GuitarRepository;

        public IGuitarRepository<AcousticClassicalGuitarDataModel> ClassicAcousticGuitars => _repositoryProvider.AcousticClassicalGuitarRepository;

        public IGuitarRepository<AcousticWesternGuitarDataModel> WesternAcousticGuitars => _repositoryProvider.AcousticWesternGuitarRepository;

        public IGuitarRepository<BassGuitarDataModel> BassGuitars => _repositoryProvider.BassGuitarRepository;

        public IGuitarRepository<ElectroGuitarDataModel> ElectricGuitars => _repositoryProvider.ElectroGuitarRepository;

        public void Dispose()
        {
            _repositoryProvider.Dispose();
        }
    }
}
