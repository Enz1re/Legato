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

        public void Create(ElectricGuitarModel item)
        {
            _context.ElectricGuitars.Add(item);
        }

        public void Delete(string vendor, string model)
        {
            var selectedGuitar = _context.ElectricGuitars.SingleOrDefault(g => g.Vendor.Name == vendor && g.Model == model);
            if (selectedGuitar != null)
            {
                _context.ElectricGuitars.Remove(selectedGuitar);
            }
        }

        public ElectricGuitarModel Get(string vendor, string model)
        {
            return _context.ElectricGuitars.SingleOrDefault(g => g.Vendor.Name == vendor && g.Model == model);
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

        public IQueryable<ElectricGuitarModel> GetAll()
        {
            return _context.ElectricGuitars.OrderBy(g => g.Id);
        }

        public void Update(ElectricGuitarModel item)
        {
            _context.ElectricGuitars.AddOrUpdate(item);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
