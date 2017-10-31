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

        public IGuitarRepository<AcousticClassicalGuitarDataModel> ClassicAcousticGuitars => _repositoryProvider.AcousticClassicalGuitarRepository;

        public IGuitarRepository<AcousticWesternGuitarDataModel> WesternAcousticGuitars => _repositoryProvider.AcousticWesternGuitarRepository;

        public IGuitarRepository<BassGuitarDataModel> BassGuitars => _repositoryProvider.BassGuitarRepository;

        public IGuitarRepository<ElectricGuitarDataModel> ElectricGuitars => _repositoryProvider.ElectricGuitarRepository;
    }
}
