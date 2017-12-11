using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Interfaces
{
    public interface IGuitarRepository<TGuitar> where TGuitar: GuitarDataModel
    {
        void Add(TGuitar guitar);

        void Update(TGuitar guitar);

        void Delete(int id);

        IEnumerable<TGuitar> Get(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<TGuitar> GetSorted(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting);

        IEnumerable<string> GetVendors();

        int GetAmount(FilterDataModel filter);
    }
}
