using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Interfaces
{
    public interface IGuitarRepository<TGuitar> where TGuitar: GuitarDataModel
    {
        IEnumerable<TGuitar> GetAll();

        IEnumerable<string> GetVendors();

        IEnumerable<TGuitar> FindByVendor(string vendor);

        IEnumerable<TGuitar> FindByCost(short from, short to);
    }
}
