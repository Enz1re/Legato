using System;
using Legato.DAL.Models;
using System.Collections.Generic;


namespace Legato.DAL.Interfaces
{
    public interface IBassGuitarRepository : IDisposable
    {
        IEnumerable<BassGuitarModel> GetAll();

        IEnumerable<BassGuitarModel> FindByVendor(string vendor);

        BassGuitarModel Get(string vendor, string model);

        void Create(BassGuitarModel item);

        void Update(BassGuitarModel item);

        void Delete(string vendor, string model);
    }
}
