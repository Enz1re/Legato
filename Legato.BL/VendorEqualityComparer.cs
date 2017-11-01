using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL
{
    class VendorEqualityComparer : IEqualityComparer<VendorDataModel>
    {
        public bool Equals(VendorDataModel v1, VendorDataModel v2)
        {
            return v1.Name == v2.Name;
        }

        public int GetHashCode(VendorDataModel vendor)
        {
            return vendor.Name.GetHashCode();
        }
    }
}
