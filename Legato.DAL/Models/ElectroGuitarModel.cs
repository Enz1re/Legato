using Legato.DAL.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    [Table("Electro")]
    public class ElectroGuitarModel : GuitarModel
    {
        [Required]
        [ValidateStringNumber]
        public byte StringNumber { get; set; }

        [Required]
        public bool HasTremoloBar { get; set; }

        [Required]
        [ValidateSoundbox]
        public string Soundbox { get; set; }

        [Required]
        [Range(8, 13)]
        public short StringCaliber { get; set; }
    }
}
