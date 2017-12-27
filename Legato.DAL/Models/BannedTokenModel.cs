using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    [Table("BannedTokens")]
    public class BannedTokenModel
    {
        [Key]
        [StringLength(256)]
        public string Token { get; set; }
    }
}
