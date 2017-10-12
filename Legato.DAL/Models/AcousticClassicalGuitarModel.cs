using Legato.DAL.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    [Table("AcousticClassic")]
    public class AcousticClassicalGuitarModel : GuitarModel
    {
        [Required]
        [ValidateClassicalGuitarStringTypeAttribute]
        public string StringType { get; set; }
    }
}
