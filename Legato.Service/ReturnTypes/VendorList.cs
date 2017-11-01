using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.ReturnTypes
{
    public class VendorList
    {
        public IEnumerable<VendorViewModel> Vendors { get; set; }
    }
}