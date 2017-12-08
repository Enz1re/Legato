using Ninject;
using Legato.ServiceDAL.Interfaces;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL
{
    public class GuitarUnitOfWork : IGuitarUnitOfWork
    {
        private readonly IGuitarRepository<AcousticClassicalGuitarDataModel> _acousticClassicalGuitarRepo;
        private readonly IGuitarRepository<AcousticWesternGuitarDataModel> _acousticWesternGuitarRepo;
        private readonly IGuitarRepository<ElectricGuitarDataModel> _electricGuitarRepo;
        private readonly IGuitarRepository<BassGuitarDataModel> _bassGuitarRepo;

        [Inject]
        public GuitarUnitOfWork(IGuitarRepository<AcousticClassicalGuitarDataModel> acousticClassicalGuitarRepo,
            IGuitarRepository<AcousticWesternGuitarDataModel> acousticWesternGuitarRepo, IGuitarRepository<ElectricGuitarDataModel> electricGuitarRepo,
            IGuitarRepository<BassGuitarDataModel> bassGuitarRepo)
        {
            _acousticClassicalGuitarRepo = acousticClassicalGuitarRepo;
            _acousticWesternGuitarRepo = acousticWesternGuitarRepo;
            _electricGuitarRepo = electricGuitarRepo;
            _bassGuitarRepo = bassGuitarRepo;
        }

        public IGuitarRepository<AcousticClassicalGuitarDataModel> ClassicAcousticGuitars => _acousticClassicalGuitarRepo;

        public IGuitarRepository<AcousticWesternGuitarDataModel> WesternAcousticGuitars => _acousticWesternGuitarRepo;

        public IGuitarRepository<ElectricGuitarDataModel> ElectricGuitars => _electricGuitarRepo;

        public IGuitarRepository<BassGuitarDataModel> BassGuitars => _bassGuitarRepo;
    }
}
