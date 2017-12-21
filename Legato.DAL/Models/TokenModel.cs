using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    [Table("TokenStorage")]
    public class TokenModel
    {
        [Key]
        [StringLength(400)]
        public string Token { get; set; }

        [Required]
        public DateTime Expiry { get; set; }
    }
}
