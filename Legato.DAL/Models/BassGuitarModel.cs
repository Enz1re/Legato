using Legato.DAL.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    [Table("Bass")]
    public class BassGuitarModel : GuitarModel
    {
        [Required]
        [ValidateBassStringNumberAttribute]
        public byte StringNumber { get; set; }

        [Required]
        [ValidateSoundboxAttribute]
        public string Soundbox { get; set; }
    }
}
