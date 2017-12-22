using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.ReturnTypes
{
    public class UserList
    {
        public IEnumerable<UserViewModel> Users { get; set; }
    }
}