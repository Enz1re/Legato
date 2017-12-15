using System;
using Ninject;
using System.Linq;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using System.Data.Entity.Migrations;
using System.Runtime.CompilerServices;
using System.Data.Entity.Validation;


[assembly: InternalsVisibleTo("Legato.DAL.Tests")]
namespace Legato.DAL.Repositories
{
    class AcousticClassicalGuitarRepository : IGuitarRepository<AcousticClassicalGuitarModel>
    {
        private IGuitarContext _context;

        [Inject]
        public AcousticClassicalGuitarRepository(IGuitarContext context)
        {
            _context = context;
        }

        public AcousticClassicalGuitarModel Get(int id)
        {
            return _context.ClassicalAcousticGuitars.FirstOrDefault(g => g.Id == id);
        }

        public void Create(AcousticClassicalGuitarModel item)
        {
            var existingVendor = _context.Vendors.SingleOrDefault(v => v.Id == item.Vendor.Id);
            if (existingVendor == null)
            {
                _context.Vendors.Add(item.Vendor);
            }

            _context.ClassicalAcousticGuitars.Add(item);
            _context.SaveChanges();
        }

        public void Update(AcousticClassicalGuitarModel item)
        {
            var existingVendor = _context.Vendors.SingleOrDefault(v => v.Id == item.Vendor.Id);
            if (existingVendor == null)
            {
                _context.Vendors.Add(item.Vendor);
            }

            _context.ClassicalAcousticGuitars.AddOrUpdate(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var selectedGuitar = Get(id);
            if (selectedGuitar != null)
            {
                var vendor = selectedGuitar.Vendor;
                var vendorName = vendor.Name;

                if (_context.WesternAcousticGuitars.Select(g => g.Vendor.Name == vendorName).Count() == 0 &&
                    _context.ElectricGuitars.Select(g => g.Vendor.Name == vendorName).Count() == 0 &&
                    _context.BassGuitars.Select(g => g.Vendor.Name == vendorName).Count() == 0)
                {
                    _context.Vendors.Remove(vendor);
                }

                _context.ClassicalAcousticGuitars.Remove(selectedGuitar);
                _context.SaveChanges();
            }
        }

        public IQueryable<AcousticClassicalGuitarModel> GetAll()
        {
            return _context.ClassicalAcousticGuitars.OrderBy(g => g.Id);
        }

        public IQueryable<AcousticClassicalGuitarModel> FindByVendors(string[] vendors)
        {
            return _context.ClassicalAcousticGuitars.Where(g => vendors.Contains(g.Vendor.Name)).OrderBy(g => g.Id);
        }

        public IQueryable<AcousticClassicalGuitarModel> FindByPrice(int from, int to)
        {
            return _context.ClassicalAcousticGuitars.Where(g => from <= g.Price && g.Price <= to).OrderBy(g => g.Id);
        }

        public IQueryable<AcousticClassicalGuitarModel> FindByVendorsAndPrice(string[] vendors, int priceFrom, int priceTo)
        {
            return _context.ClassicalAcousticGuitars.Where
            (
                g => vendors.Contains(g.Vendor.Name) && (priceFrom <= g.Price && g.Price <= priceTo)
            )
            .OrderBy(g => g.Id);
        }       

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
