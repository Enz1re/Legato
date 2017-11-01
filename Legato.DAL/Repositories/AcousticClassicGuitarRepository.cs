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

        public void Create(AcousticClassicalGuitarModel item)
        {
            _context.ClassicAcousticGuitars.Add(item);
        }

        public void Delete(string vendor, string model)
        {
            var selectedGuitar = _context.ClassicAcousticGuitars.Find(vendor, model);
            if (selectedGuitar != null)
            {
                _context.ClassicAcousticGuitars.Remove(selectedGuitar);
            }
        }

        public AcousticClassicalGuitarModel Get(string vendor, string model)
        {
            return _context.ClassicAcousticGuitars.SingleOrDefault(g => g.Vendor.Name == vendor && g.Model == model);
        }

        public IQueryable<AcousticClassicalGuitarModel> FindByVendors(string[] vendors)
        {
            return _context.ClassicAcousticGuitars.Where(g => vendors.Contains(g.Vendor.Name)).OrderBy(g => g.Id);
        }

        public IQueryable<AcousticClassicalGuitarModel> FindByPrice(int from, int to)
        {
            return _context.ClassicAcousticGuitars.Where(g => from <= g.Price && g.Price <= to).OrderBy(g => g.Id);
        }

        public IQueryable<AcousticClassicalGuitarModel> GetAll()
        {
            return _context.ClassicAcousticGuitars;
        }

        public int GetItemAmount()
        {
            return _context.ClassicAcousticGuitars.Count();
        }

        public void Update(AcousticClassicalGuitarModel item)
        {
            _context.ClassicAcousticGuitars.AddOrUpdate(item);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
