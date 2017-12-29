using Ninject;
using System.Linq;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using System.Data.Entity.Migrations;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("Legato.DAL.Tests")]
namespace Legato.DAL.Repositories
{
    class BassGuitarRepository : IGuitarRepository<BassGuitarModel>
    {
        private ILegatoContext _context;

        [Inject]
        public BassGuitarRepository(ILegatoContext context)
        {
            _context = context;
        }

        public BassGuitarModel Get(int id)
        {
            return _context.BassGuitars.FirstOrDefault(g => g.Id == id);
        }

        public void Create(BassGuitarModel item)
        {
            var existingVendor = _context.Vendors.SingleOrDefault(v => v.Id == item.Vendor.Id);
            if (existingVendor == null)
            {
                _context.Vendors.Add(item.Vendor);
            }

            _context.BassGuitars.Add(item);
            _context.SaveChanges();
        }

        public void Update(BassGuitarModel item)
        {
            var existingVendor = _context.Vendors.SingleOrDefault(v => v.Name == item.Vendor.Name);
            if (existingVendor == null)
            {
                _context.Vendors.Add(item.Vendor);
            }

            _context.BassGuitars.AddOrUpdate(item);
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
                    _context.ElectricGuitars.Select(g => g.Vendor.Name == vendorName).Count() == 0)
                {
                    _context.Vendors.Remove(vendor);
                }

                _context.BassGuitars.Remove(selectedGuitar);
                _context.SaveChanges();
            }
        }

        public IQueryable<BassGuitarModel> GetAll()
        {
            return _context.BassGuitars.OrderBy(g => g.Id);
        }

        public IQueryable<BassGuitarModel> FindByVendors(string[] vendors)
        {
            return _context.BassGuitars.Where(g => vendors.Contains(g.Vendor.Name)).OrderBy(g => g.Id);
        }

        public IQueryable<BassGuitarModel> FindByPrice(int from, int to)
        {
            return _context.BassGuitars.Where(g => from <= g.Price && g.Price <= to).OrderBy(g => g.Id);
        }

        public IQueryable<BassGuitarModel> FindByVendorsAndPrice(string[] vendors, int priceFrom, int priceTo)
        {
            return _context.BassGuitars.Where
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
