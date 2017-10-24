﻿using Ninject;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;


namespace Legato.DAL.Repositories
{
    public class RepositoryProvider : IRepositoryProvider
    {
        private IGuitarRepository<AcousticClassicalGuitarModel> _acousticClassicalGuitarRepo;
        private IGuitarRepository<AcousticWesternGuitarModel> _acousticWesternGuitarRepo;
        private IGuitarRepository<ElectricGuitarModel> _electricGuitarRepo;
        private IGuitarRepository<BassGuitarModel> _bassGuitarRepo;

        [Inject]
        public RepositoryProvider(IGuitarRepository<AcousticClassicalGuitarModel> acousticClassicalGuitarRepo, IGuitarRepository<AcousticWesternGuitarModel> acousticWesternGuitarRepo,
            IGuitarRepository<ElectricGuitarModel> electricGuitarRepo, IGuitarRepository<BassGuitarModel> bassGuitarRepo)
        {
            _acousticClassicalGuitarRepo = acousticClassicalGuitarRepo;
            _acousticWesternGuitarRepo = acousticWesternGuitarRepo;
            _electricGuitarRepo = electricGuitarRepo;
            _bassGuitarRepo = bassGuitarRepo;
        }

        public IGuitarRepository<AcousticClassicalGuitarModel> AcousticClassicalGuitarRepository => _acousticClassicalGuitarRepo;

        public IGuitarRepository<AcousticWesternGuitarModel> AcousticWesternGuitarRepository => _acousticWesternGuitarRepo;

        public IGuitarRepository<ElectricGuitarModel> ElectricGuitarRepository => _electricGuitarRepo;

        public IGuitarRepository<BassGuitarModel> BassGuitarRepository => _bassGuitarRepo;

        public void Dispose()
        {
            _acousticClassicalGuitarRepo.Dispose();
            _acousticWesternGuitarRepo.Dispose();
            _electricGuitarRepo.Dispose();
            _bassGuitarRepo.Dispose();
        }
    }
}
