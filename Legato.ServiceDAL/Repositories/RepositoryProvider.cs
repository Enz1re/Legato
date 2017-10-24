using Ninject;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Repositories
{
    class RepositoryProvider : IServiceRepositoryProvider
    {
        private IGuitarRepository<GuitarDataModel> _guitarRepo;
        private IGuitarRepository<AcousticClassicalGuitarDataModel> _acousticClassicalGuitarRepo;
        private IGuitarRepository<AcousticWesternGuitarDataModel> _acousticWesternGuitarRepo;
        private IGuitarRepository<ElectricGuitarDataModel> _electricGuitarRepo;
        private IGuitarRepository<BassGuitarDataModel> _bassGuitarRepo;

        [Inject]
        public RepositoryProvider(IGuitarRepository<GuitarDataModel> guitarRepo, IGuitarRepository<AcousticClassicalGuitarDataModel> acousticClassicalGuitarRepo,
            IGuitarRepository<AcousticWesternGuitarDataModel> acousticWesternGuitarRepo, IGuitarRepository<ElectricGuitarDataModel> electricGuitarRepo,
            IGuitarRepository<BassGuitarDataModel> bassGuitarRepo)
        {
            _guitarRepo = guitarRepo;
            _acousticClassicalGuitarRepo = acousticClassicalGuitarRepo;
            _acousticWesternGuitarRepo = acousticWesternGuitarRepo;
            _electricGuitarRepo = electricGuitarRepo;
            _bassGuitarRepo = bassGuitarRepo;
        }

        public IGuitarRepository<GuitarDataModel> GuitarRepository => _guitarRepo;

        public IGuitarRepository<AcousticClassicalGuitarDataModel> AcousticClassicalGuitarRepository => _acousticClassicalGuitarRepo;

        public IGuitarRepository<AcousticWesternGuitarDataModel> AcousticWesternGuitarRepository => _acousticWesternGuitarRepo;

        public IGuitarRepository<ElectricGuitarDataModel> ElectricGuitarRepository => _electricGuitarRepo;

        public IGuitarRepository<BassGuitarDataModel> BassGuitarRepository => _bassGuitarRepo;
    }
}
