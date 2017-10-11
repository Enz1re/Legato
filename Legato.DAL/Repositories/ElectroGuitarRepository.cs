using System;
using Ninject;
using System.Linq;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity.Migrations;


namespace Legato.DAL.Repositories
{
    class ElectroGuitarRepository : IElectroGuitarRepository
    {
        private bool _disposed;
        private IGuitarContext _context;

        [Inject]
        public ElectroGuitarRepository(IGuitarContext context)
        {
            _context = context;
        }

        public void Create(ElectroGuitarModel item)
        {
            _context.ElectroGuitars.Add(item);
        }

        public void Delete(string vendor, string model)
        {
            var selectedGuitar = _context.ElectroGuitars.SingleOrDefault(g => g.Vendor == vendor && g.Model == model);
            if (selectedGuitar != null)
            {
                _context.ElectroGuitars.Remove(selectedGuitar);
            }
        }

        public ElectroGuitarModel Get(string vendor, string model)
        {
            return _context.ElectroGuitars.SingleOrDefault(g => g.Vendor == vendor && g.Model == model);
        }

        public IEnumerable<ElectroGuitarModel> FindByVendor(string vendor)
        {
            return _context.ElectroGuitars.Where(g => g.Vendor == vendor);
        }

        public IEnumerable<ElectroGuitarModel> GetAll()
        {
            return _context.ElectroGuitars;
        }

        public void Update(ElectroGuitarModel item)
        {
            _context.ElectroGuitars.AddOrUpdate(item);
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

        ~ElectroGuitarRepository()
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
