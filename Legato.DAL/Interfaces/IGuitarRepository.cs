using System;
using System.Linq;
using Legato.DAL.Models;


namespace Legato.DAL.Interfaces
{
    public interface IGuitarRepository<TGuitar> : IDisposable where TGuitar: GuitarModel
    {
        IQueryable<TGuitar> GetAll();

        IQueryable<TGuitar> FindByVendors(string[] vendors);

        IQueryable<TGuitar> FindByPrice(int from, int to);

        IQueryable<TGuitar> FindByVendorsAndPrice(string[] vendors, int priceFrom, int priceTo);

        TGuitar Get(string vendor, string model);

        int GetItemAmount();

        void Create(TGuitar item);

        void Update(TGuitar item);

        void Delete(string vendor, string model);
    }
}
