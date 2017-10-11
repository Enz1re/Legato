using Ninject;
using Legato.DAL.Interfaces;


namespace Legato.DAL.Repositories
{
    public class RepositoryProvider : IRepositoryProvider
    {
        private IAcousticClassicalGuitarRepository _acousticClassicalGuitarRepo;
        private IAcousticWesternGuitarRepository _acousticWesternGuitarRepo;
        private IElectroGuitarRepository _electroGuitarRepo;
        private IBassGuitarRepository _bassGuitarRepo;

        [Inject]
        public RepositoryProvider(IAcousticClassicalGuitarRepository acousticClassicalGuitarRepo, IAcousticWesternGuitarRepository acousticWesternGuitarRepo,
            IElectroGuitarRepository electroGuitarRepo, IBassGuitarRepository bassGuitarRepo)
        {
            _acousticClassicalGuitarRepo = acousticClassicalGuitarRepo;
            _acousticWesternGuitarRepo = acousticWesternGuitarRepo;
            _electroGuitarRepo = electroGuitarRepo;
            _bassGuitarRepo = bassGuitarRepo;
        }

        public IAcousticClassicalGuitarRepository AcousticClassicalGuitarRepository => _acousticClassicalGuitarRepo;

        public IAcousticWesternGuitarRepository AcousticWesternGuitarRepository => _acousticWesternGuitarRepo;

        public IBassGuitarRepository BassGuitarRepository => _bassGuitarRepo;

        public IElectroGuitarRepository ElectroGuitarRepository => _electroGuitarRepo;
    }
}
