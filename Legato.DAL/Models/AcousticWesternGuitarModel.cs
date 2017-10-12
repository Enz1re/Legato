using Legato.DAL.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    [Table("AcousticWestern")]
    public class AcousticWesternGuitarModel : GuitarModel
    {
        [Required]
        [ValidateStringNumberAttribute]
        public byte StringNumber { get; set; }

        [Required]
        [Range(8, 13)]
        public short StringCaliber { get; set; }
    }
}
