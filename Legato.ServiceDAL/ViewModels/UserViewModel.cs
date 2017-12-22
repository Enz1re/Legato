namespace Legato.ServiceDAL.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsAuthenticated { get; set; }

        public string Role { get; set; }
    }
}
