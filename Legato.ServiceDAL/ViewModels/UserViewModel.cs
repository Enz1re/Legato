namespace Legato.ServiceDAL.ViewModels
{
    class UserViewModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string EncryptedPassword { get; set; }

        public string UserRole { get; set; }
    }
}
