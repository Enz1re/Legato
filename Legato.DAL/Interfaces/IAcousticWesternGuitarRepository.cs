using System;
using Legato.DAL.Models;
using System.Collections.Generic;


namespace Legato.DAL.Interfaces
{
    public interface IAcousticWesternGuitarRepository : IDisposable
    {
        IEnumerable<AcousticWesternGuitarModel> GetAll();

        IEnumerable<AcousticWesternGuitarModel> FindByVendor(string vendor);

        AcousticWesternGuitarModel Get(string vendor, string model);

        void Create(AcousticWesternGuitarModel item);

        void Update(AcousticWesternGuitarModel item);

        void Delete(string vendor, string model);
    }
}
