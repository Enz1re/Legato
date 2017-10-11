using System;
using Legato.DAL.Models;
using System.Collections.Generic;


namespace Legato.DAL.Interfaces
{
    public interface IAcousticClassicalGuitarRepository : IDisposable
    {
        IEnumerable<AcousticClassicalGuitarModel> GetAll();

        IEnumerable<AcousticClassicalGuitarModel> FindByVendor(string vendor);

        AcousticClassicalGuitarModel Get(string vendor, string model);

        void Create(AcousticClassicalGuitarModel item);

        void Update(AcousticClassicalGuitarModel item);

        void Delete(string vendor, string model);
    }
}
