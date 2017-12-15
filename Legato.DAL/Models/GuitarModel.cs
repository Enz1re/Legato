using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    public abstract class GuitarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public short Mensura { get; set; }

        [Required]
        public int Price { get; set; }

        public virtual VendorModel Vendor { get; set; }

        [Required]
        [ForeignKey("Vendor")]
        public int VendorId { get; set; }

        public string ImgPath { get; set; }
    }
}
