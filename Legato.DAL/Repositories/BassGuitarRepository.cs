﻿using System;
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
    class BassGuitarRepository : IGuitarRepository<BassGuitarModel>
    {
        private IGuitarContext _context;

        [Inject]
        public BassGuitarRepository(IGuitarContext context)
        {
            _context = context;
        }

        public void Create(BassGuitarModel item)
        {
            _context.BassGuitars.Add(item);
        }

        public void Delete(string vendor, string model)
        {
            var selectedGuitar = _context.BassGuitars.SingleOrDefault(g => g.Vendor.Name == vendor && g.Model == model);
            if (selectedGuitar != null)
            {
                _context.BassGuitars.Remove(selectedGuitar);
            }
        }

        public BassGuitarModel Get(string vendor, string model)
        {
            return _context.BassGuitars.SingleOrDefault(g => g.Vendor.Name == vendor && g.Model == model);
        }

        public IEnumerable<BassGuitarModel> FindByVendor(string vendor)
        {
            return _context.BassGuitars.Where(g => g.Vendor.Name == vendor).ToList();
        }

        public IEnumerable<BassGuitarModel> GetAll()
        {
            return _context.BassGuitars.ToList();
        }

        public void Update(BassGuitarModel item)
        {
            _context.BassGuitars.AddOrUpdate(item);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
