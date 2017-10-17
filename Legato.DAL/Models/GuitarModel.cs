using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    public abstract class GuitarModel
    {
        [Key]
        [Required]
        [Column(Order = 1)]
        public string Vendor { get; set; }

        [Key]
        [Required]
        [Column(Order = 2)]
        public string Model { get; set; }

        [Required]
        public short Mensura { get; set; }

        [Required]
        public int Price { get; set; }

        public string ImgPath { get; set; }
    }
}
