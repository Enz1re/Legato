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
        private IGuitarRepository<ElectroGuitarDataModel> _electroGuitarRepo;
        private IGuitarRepository<BassGuitarDataModel> _bassGuitarRepo;

        [Inject]
        public RepositoryProvider(IGuitarRepository<GuitarDataModel> guitarRepo, IGuitarRepository<AcousticClassicalGuitarDataModel> acousticClassicalGuitarRepo,
            IGuitarRepository<AcousticWesternGuitarDataModel> acousticWesternGuitarRepo, IGuitarRepository<ElectroGuitarDataModel> electroGuitarRepo,
            IGuitarRepository<BassGuitarDataModel> bassGuitarRepo)
        {
            _guitarRepo = guitarRepo;
            _acousticClassicalGuitarRepo = acousticClassicalGuitarRepo;
            _acousticWesternGuitarRepo = acousticWesternGuitarRepo;
            _electroGuitarRepo = electroGuitarRepo;
            _bassGuitarRepo = bassGuitarRepo;
        }

        public IGuitarRepository<GuitarDataModel> GuitarRepository => _guitarRepo;

        public IGuitarRepository<AcousticClassicalGuitarDataModel> AcousticClassicalGuitarRepository => _acousticClassicalGuitarRepo;

        public IGuitarRepository<AcousticWesternGuitarDataModel> AcousticWesternGuitarRepository => _acousticWesternGuitarRepo;

        public IGuitarRepository<ElectroGuitarDataModel> ElectroGuitarRepository => _electroGuitarRepo;

        public IGuitarRepository<BassGuitarDataModel> BassGuitarRepository => _bassGuitarRepo;

        public void Dispose()
        {
            _guitarRepo.Dispose();
            _acousticClassicalGuitarRepo.Dispose();
            _acousticWesternGuitarRepo.Dispose();
            _electroGuitarRepo.Dispose();
            _bassGuitarRepo.Dispose();
        }
    }
}
