using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    public class TokenModel
    {
        [Key]
        [Index("token_index", IsClustered = true, IsUnique = true)]
        public string Token { get; set; }

        [Required]
        public DateTime Expiry { get; set; }
    }
}
