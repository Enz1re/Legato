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

        public void Create(AcousticWesternGuitarModel item)
        {
            _context.WesternAcousticGuitars.Add(item);
        }

        public void Delete(string vendor, string model)
        {
            var selectedGuitar = _context.WesternAcousticGuitars.SingleOrDefault(g => g.Vendor.Name == vendor && g.Model == model);
            if (selectedGuitar != null)
            {
                _context.WesternAcousticGuitars.Remove(selectedGuitar);
            }
        }

        public AcousticWesternGuitarModel Get(string vendor, string model)
        {
            return _context.WesternAcousticGuitars.SingleOrDefault(g => g.Vendor.Name == vendor && g.Model == model);
        }

        public IQueryable<AcousticWesternGuitarModel> FindByVendors(string[] vendors)
        {
            return _context.WesternAcousticGuitars.Where(g => vendors.Contains(g.Vendor.Name)).OrderBy(g => g.Id);
        }

        public IQueryable<AcousticWesternGuitarModel> FindByPrice(int from, int to)
        {
            return _context.WesternAcousticGuitars.Where(g => from <= g.Price && g.Price <= to).OrderBy(g => g.Id);
        }

        public IQueryable<AcousticWesternGuitarModel> GetAll()
        {
            return _context.WesternAcousticGuitars.OrderBy(g => g.Id);
        }

        public int GetItemAmount()
        {
            return _context.WesternAcousticGuitars.Count();
        }

        public void Update(AcousticWesternGuitarModel item)
        {
            _context.WesternAcousticGuitars.AddOrUpdate(item);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
