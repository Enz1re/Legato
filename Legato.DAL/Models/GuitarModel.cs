using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    public abstract class GuitarModel
    {
        [Required]
        [ForeignKey("Vendor")]
        public VendorModel Vendor { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public short Mensura { get; set; }

        [Required]
        public int Price { get; set; }

        public string ImgPath { get; set; }
    }
}
