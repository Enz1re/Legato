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

        public IEnumerable<AcousticClassicalGuitarModel> FindByVendor(string vendor)
        {
            return _context.ClassicAcousticGuitars.Where(g => g.Vendor.Name == vendor).ToList();
        }

        public IEnumerable<AcousticClassicalGuitarModel> GetAll()
        {
            return _context.ClassicAcousticGuitars.ToList();
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
