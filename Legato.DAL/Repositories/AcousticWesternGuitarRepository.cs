using System;
using Ninject;
using System.Linq;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("Legato.DAL.Tests")]
namespace Legato.DAL.Repositories
{
    class AcousticWesternGuitarRepository : IAcousticWesternGuitarRepository
    {
        private bool _disposed = false;
        private IGuitarContext _context;

        [Inject]
        public AcousticWesternGuitarRepository(IGuitarContext context)
        {
            _context = context;
        }

        public void Create(AcousticWesternGuitarModel item)
        {
            _context.WesternAcousticGuitars.Add(item);
        }

        public void Delete(string vendor, string model)
        {
            var selectedGuitar = _context.WesternAcousticGuitars.SingleOrDefault(g => g.Vendor == vendor && g.Model == model);
            if (selectedGuitar != null)
            {
                _context.WesternAcousticGuitars.Remove(selectedGuitar);
            }
        }

        public AcousticWesternGuitarModel Get(string vendor, string model)
        {
            return _context.WesternAcousticGuitars.SingleOrDefault(g => g.Vendor == vendor && g.Model == model);
        }

        public IEnumerable<AcousticWesternGuitarModel> FindByVendor(string vendor)
        {
            return _context.WesternAcousticGuitars.Where(g => g.Vendor == vendor);
        }

        public IEnumerable<AcousticWesternGuitarModel> GetAll()
        {
            return _context.WesternAcousticGuitars.ToList();
        }

        public void Update(AcousticWesternGuitarModel item)
        {
            _context.WesternAcousticGuitars.AddOrUpdate(item);
        }
        
        protected virtual void Dispose(bool disposing)
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

        ~AcousticWesternGuitarRepository()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
