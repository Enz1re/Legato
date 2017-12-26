using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    [Table("Users")]
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string EncryptedPassword { get; set; }

        [Required]
        public bool IsAuthenticated { get; set; }

        public virtual UserRole UserRole { get; set; }

        [ForeignKey("UserRole")]
        public int? UserRoleId { get; set; }
    }
}
