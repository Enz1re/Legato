using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    [Table("Vendors")]
    public class VendorModel
    {
        [Required]
        public string Name { get; set; }
    }
}
