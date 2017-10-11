using System;
using Legato.DAL.Models;
using System.Collections.Generic;


namespace Legato.DAL.Interfaces
{
    public interface IElectroGuitarRepository : IDisposable
    {
        IEnumerable<ElectroGuitarModel> GetAll();

        IEnumerable<ElectroGuitarModel> FindByVendor(string vendor);

        ElectroGuitarModel Get(string vendor, string model);

        void Create(ElectroGuitarModel item);

        void Update(ElectroGuitarModel item);

        void Delete(string vendor, string model);
    }
}
