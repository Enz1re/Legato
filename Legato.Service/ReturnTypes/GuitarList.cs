using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.ReturnTypes
{
    public class GuitarList
    {
        public IEnumerable<GuitarViewModel> Guitars { get; set; }
    }
}