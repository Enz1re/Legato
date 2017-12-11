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
        private IGuitarContext _context;

        [Inject]
        public BassGuitarRepository(IGuitarContext context)
        {
            _context = context;
        }

        public BassGuitarModel Get(int id)
        {
            return _context.BassGuitars.FirstOrDefault(g => g.Id == id);
        }

        public void Create(BassGuitarModel item)
        {
            _context.BassGuitars.Add(item);
            _context.SaveChanges();
        }

        public void Update(BassGuitarModel item)
        {
            _context.BassGuitars.AddOrUpdate(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var selectedGuitar = Get(id);
            if (selectedGuitar != null)
            {
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
