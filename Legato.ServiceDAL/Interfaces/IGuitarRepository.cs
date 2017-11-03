using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Interfaces
{
    public interface IGuitarRepository<TGuitar> where TGuitar: GuitarDataModel
    {
        IEnumerable<TGuitar> Get(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<string> GetVendors();

        int GetAmount();
    }
}
