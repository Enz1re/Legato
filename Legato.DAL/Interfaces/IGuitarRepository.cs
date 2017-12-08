using System;
using System.Linq;
using Legato.DAL.Models;


namespace Legato.DAL.Interfaces
{
    public interface IGuitarRepository<TGuitar> : IDisposable where TGuitar: GuitarModel
    {
        TGuitar Get(int Id);

        void Create(TGuitar item);

        void Update(TGuitar guitar);

        void Delete(int id);

        IQueryable<TGuitar> GetAll();

        IQueryable<TGuitar> FindByVendors(string[] vendors);

        IQueryable<TGuitar> FindByPrice(int from, int to);

        IQueryable<TGuitar> FindByVendorsAndPrice(string[] vendors, int priceFrom, int priceTo);
    }
}
