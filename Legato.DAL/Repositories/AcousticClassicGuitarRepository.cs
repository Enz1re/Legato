using Ninject;
using System.Linq;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using System.Data.Entity.Migrations;
using System.Runtime.CompilerServices;


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
            return _context.ClassicAcousticGuitars.FirstOrDefault(g => g.Id == id);
        }

        public void Create(AcousticClassicalGuitarModel item)
        {
            _context.ClassicAcousticGuitars.Add(item);
            _context.SaveChanges();
        }

        public void Update(AcousticClassicalGuitarModel item)
        {
            _context.ClassicAcousticGuitars.AddOrUpdate(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var selectedGuitar = Get(id);
            if (selectedGuitar != null)
            {
                _context.ClassicAcousticGuitars.Remove(selectedGuitar);
                _context.SaveChanges();
            }
        }

        public IQueryable<AcousticClassicalGuitarModel> GetAll()
        {
            return _context.ClassicAcousticGuitars.OrderBy(g => g.Id);
        }

        public IQueryable<AcousticClassicalGuitarModel> FindByVendors(string[] vendors)
        {
            return _context.ClassicAcousticGuitars.Where(g => vendors.Contains(g.Vendor.Name)).OrderBy(g => g.Id);
        }

        public IQueryable<AcousticClassicalGuitarModel> FindByPrice(int from, int to)
        {
            return _context.ClassicAcousticGuitars.Where(g => from <= g.Price && g.Price <= to).OrderBy(g => g.Id);
        }

        public IQueryable<AcousticClassicalGuitarModel> FindByVendorsAndPrice(string[] vendors, int priceFrom, int priceTo)
        {
            return _context.ClassicAcousticGuitars.Where
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
