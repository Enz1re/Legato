using Ninject;
using System.Linq;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using System.Data.Entity.Migrations;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("Legato.DAL.Tests")]
namespace Legato.DAL.Repositories
{
    class AcousticWesternGuitarRepository : IGuitarRepository<AcousticWesternGuitarModel>
    {
        private IGuitarContext _context;

        [Inject]
        public AcousticWesternGuitarRepository(IGuitarContext context)
        {
            _context = context;
        }

        public AcousticWesternGuitarModel Get(int id)
        {
            return _context.WesternAcousticGuitars.FirstOrDefault(g => g.Id == id);
        }

        public void Create(AcousticWesternGuitarModel item)
        {
            var existingVendor = _context.Vendors.SingleOrDefault(v => v.Id == item.Vendor.Id);
            if (existingVendor == null)
            {
                _context.Vendors.Add(item.Vendor);
            }

            _context.WesternAcousticGuitars.Add(item);
            _context.SaveChanges();
        }

        public void Update(AcousticWesternGuitarModel item)
        {
            var existingVendor = _context.Vendors.SingleOrDefault(v => v.Name == item.Vendor.Name);
            if (existingVendor == null)
            {
                _context.Vendors.Add(item.Vendor);
            }

            _context.WesternAcousticGuitars.AddOrUpdate(item);
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
                    _context.ElectricGuitars.Select(g => g.Vendor.Name == vendorName).Count() == 0 &&
                    _context.BassGuitars.Select(g => g.Vendor.Name == vendorName).Count() == 0)
                {
                    _context.Vendors.Remove(vendor);
                }

                _context.WesternAcousticGuitars.Remove(selectedGuitar);
                _context.SaveChanges();
            }
        }

        public IQueryable<AcousticWesternGuitarModel> GetAll()
        {
            return _context.WesternAcousticGuitars.OrderBy(g => g.Id);
        }

        public IQueryable<AcousticWesternGuitarModel> FindByVendors(string[] vendors)
        {
            return _context.WesternAcousticGuitars.Where(g => vendors.Contains(g.Vendor.Name)).OrderBy(g => g.Id);
        }

        public IQueryable<AcousticWesternGuitarModel> FindByPrice(int from, int to)
        {
            return _context.WesternAcousticGuitars.Where(g => from <= g.Price && g.Price <= to).OrderBy(g => g.Id);
        }

        public IQueryable<AcousticWesternGuitarModel> FindByVendorsAndPrice(string[] vendors, int priceFrom, int priceTo)
        {
            return _context.WesternAcousticGuitars.Where
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
