using System;
using Ninject;
using Legato.DAL.Interfaces;


namespace Legato.DAL.Models
{
    public class GuitarUnitOfWork : IGuitarUnitOfWork
    {
        private bool _disposed;
        private readonly IGuitarContext _context;
        private readonly IRepositoryProvider _repositoryProvider;
        
        [Inject]
        public GuitarUnitOfWork(IGuitarContext context, IRepositoryProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;
            _context = context;
        }

        public IAcousticClassicalGuitarRepository ClassicAcousticGuitars
        {
            get { return _repositoryProvider.AcousticClassicalGuitarRepository; }
        }

        public IAcousticWesternGuitarRepository WesternAcousticGuitars
        {
            get { return _repositoryProvider.AcousticWesternGuitarRepository; }
        }

        public IBassGuitarRepository BassGuitars
        {
            get { return _repositoryProvider.BassGuitarRepository; }
        }

        public IElectricGuitarRepository ElectricGuitars
        {
            get { return _repositoryProvider.ElectricGuitarRepository; }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
