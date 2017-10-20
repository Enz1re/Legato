﻿using Ninject;
using Legato.DAL.Interfaces;


namespace Legato.DAL.Repositories
{
    public class RepositoryProvider : IRepositoryProvider
    {
        private IAcousticClassicalGuitarRepository _acousticClassicalGuitarRepo;
        private IAcousticWesternGuitarRepository _acousticWesternGuitarRepo;
        private IElectroGuitarRepository _electricGuitarRepo;
        private IBassGuitarRepository _bassGuitarRepo;

        [Inject]
        public RepositoryProvider(IAcousticClassicalGuitarRepository acousticClassicalGuitarRepo, IAcousticWesternGuitarRepository acousticWesternGuitarRepo,
            IElectroGuitarRepository electroGuitarRepo, IBassGuitarRepository bassGuitarRepo)
        {
            _acousticClassicalGuitarRepo = acousticClassicalGuitarRepo;
            _acousticWesternGuitarRepo = acousticWesternGuitarRepo;
            _electricGuitarRepo = electroGuitarRepo;
            _bassGuitarRepo = bassGuitarRepo;
        }

        public IAcousticClassicalGuitarRepository AcousticClassicalGuitarRepository => _acousticClassicalGuitarRepo;

        public IAcousticWesternGuitarRepository AcousticWesternGuitarRepository => _acousticWesternGuitarRepo;

        public IElectroGuitarRepository ElectroGuitarRepository => _electricGuitarRepo;

        public IBassGuitarRepository BassGuitarRepository => _bassGuitarRepo;

        public void Dispose()
        {
            _acousticClassicalGuitarRepo.Dispose();
            _acousticWesternGuitarRepo.Dispose();
            _electricGuitarRepo.Dispose();
            _bassGuitarRepo.Dispose();
        }
    }
}
