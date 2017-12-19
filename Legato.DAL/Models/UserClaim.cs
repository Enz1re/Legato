using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    [Table("UserClaims")]
    public class UserClaim
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClaimId { get; set; }

        [Required]
        public string ClaimName { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
