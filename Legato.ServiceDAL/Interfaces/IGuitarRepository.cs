using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Interfaces
{
    public interface IGuitarRepository<TGuitar> where TGuitar: GuitarDataModel
    {
        IEnumerable<TGuitar> GetAll(int lowerBound, int upperBound);

        IEnumerable<string> GetVendors();

        int GetAmount();

        IEnumerable<TGuitar> FindByVendors(string[] vendors, int lowerBound, int upperBound);

        IEnumerable<TGuitar> FindByCost(int from, int to, int lowerBound, int upperBound);
    }
}
