using Ninject;
using System.Linq;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("Legato.DAL.Tests")]
namespace Legato.DAL.Repositories
{
    class ElectricGuitarRepository : IElectricGuitarRepository
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
            var selectedGuitar = _context.ElectricGuitars.SingleOrDefault(g => g.Vendor == vendor && g.Model == model);
            if (selectedGuitar != null)
            {
                _context.ElectricGuitars.Remove(selectedGuitar);
            }
        }

        public ElectricGuitarModel Get(string vendor, string model)
        {
            return _context.ElectricGuitars.SingleOrDefault(g => g.Vendor == vendor && g.Model == model);
        }

        public IEnumerable<ElectricGuitarModel> FindByVendor(string vendor)
        {
            return _context.ElectricGuitars.Where(g => g.Vendor == vendor).ToList();
        }

        public IEnumerable<ElectricGuitarModel> GetAll()
        {
            return _context.ElectricGuitars.ToList();
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
