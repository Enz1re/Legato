using System;
using Ninject;
using System.Linq;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using System.Data.Entity.Migrations;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("Legato.DAL.Tests")]
namespace Legato.DAL.Repositories
{
    class ElectricGuitarRepository : IGuitarRepository<ElectricGuitarModel>
    {
        private IGuitarContext _context;

        [Inject]
        public ElectricGuitarRepository(IGuitarContext context)
        {
            _context = context;
        }

        public ElectricGuitarModel Get(int id)
        {
            return _context.ElectricGuitars.FirstOrDefault(g => g.Id == id);
        }

        public void Create(ElectricGuitarModel item)
        {
            var existingVendor = _context.Vendors.SingleOrDefault(v => v.Id == item.Vendor.Id);
            if (existingVendor == null)
            {
                _context.Vendors.Add(item.Vendor);
            }

            _context.ElectricGuitars.Add(item);
            _context.SaveChanges();
        }

        public void Update(ElectricGuitarModel item)
        {
            var existingVendor = _context.Vendors.SingleOrDefault(v => v.Name == item.Vendor.Name);
            if (existingVendor == null)
            {
                _context.Vendors.Add(item.Vendor);
            }

            _context.ElectricGuitars.AddOrUpdate(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var selectedGuitar = Get(id);
            if (selectedGuitar != null)
            {
                var vendor = selectedGuitar.Vendor;
                var vendorName = vendor.Name;

                if (_context.ClassicalAcousticGuitars.Select(g => g.Vendor.Name == vendorName).Count() == 0 &&
                    _context.WesternAcousticGuitars.Select(g => g.Vendor.Name == vendorName).Count() == 0 &&
                    _context.BassGuitars.Select(g => g.Vendor.Name == vendorName).Count() == 0)
                {
                    _context.Vendors.Remove(vendor);
                }

                _context.ElectricGuitars.Remove(selectedGuitar);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException($"No guitar with id '{id}' was found in the database");
            }
        }

        public IQueryable<ElectricGuitarModel> GetAll()
        {
            return _context.ElectricGuitars.OrderBy(g => g.Id);
        }

        public IQueryable<ElectricGuitarModel> FindByVendors(string[] vendors)
        {
            return _context.ElectricGuitars.Where(g => vendors.Contains(g.Vendor.Name)).OrderBy(g => g.Id);
        }

        public IQueryable<ElectricGuitarModel> FindByPrice(int from, int to)
        {
            return _context.ElectricGuitars.Where(g => from <= g.Price && g.Price <= to).OrderBy(g => g.Id);
        }

        public IQueryable<ElectricGuitarModel> FindByVendorsAndPrice(string[] vendors, int priceFrom, int priceTo)
        {
            return _context.ElectricGuitars.Where
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
