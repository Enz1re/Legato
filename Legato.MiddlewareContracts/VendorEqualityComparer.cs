using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.MiddlewareContracts
{
    public class VendorEqualityComparer : IEqualityComparer<VendorDataModel>
    {
        public bool Equals(VendorDataModel x, VendorDataModel y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(VendorDataModel obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
