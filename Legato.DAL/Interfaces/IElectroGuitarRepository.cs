using System;
using Legato.DAL.Models;
using System.Collections.Generic;


namespace Legato.DAL.Interfaces
{
    public interface IElectricGuitarRepository : IDisposable
    {
        IEnumerable<ElectricGuitarModel> GetAll();

        IEnumerable<ElectricGuitarModel> FindByVendor(string vendor);

        ElectricGuitarModel Get(string vendor, string model);

        void Create(ElectricGuitarModel item);

        void Update(ElectricGuitarModel item);

        void Delete(string vendor, string model);
    }
}
