using System.Collections.Generic;


namespace Legato.ServiceDAL.Interfaces
{
    public interface IGuitarRepository<T>
    {
        IEnumerable<T> GetAll();

        IEnumerable<string> GetVendors();

        IEnumerable<T> FindByVendor(string vendor);

        IEnumerable<T> FindByCost(short from, short to);
    }
}
