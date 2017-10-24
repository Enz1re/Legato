using System;
using Legato.DAL.Models;
using System.Collections.Generic;


namespace Legato.DAL.Interfaces
{
    public interface IGuitarRepository<TGuitar> : IDisposable where TGuitar: GuitarModel
    {
        IEnumerable<TGuitar> GetAll();

        IEnumerable<TGuitar> FindByVendor(string vendor);

        TGuitar Get(string vendor, string model);

        void Create(TGuitar item);

        void Update(TGuitar item);

        void Delete(string vendor, string model);
    }
}
