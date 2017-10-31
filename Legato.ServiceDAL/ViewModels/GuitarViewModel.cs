namespace Legato.ServiceDAL.ViewModels
{
    public abstract class GuitarViewModel
    {
        public VendorViewModel Vendor { get; set; }

        public string Model { get; set; }

        public short Mensura { get; set; }

        public int Price { get; set; }

        public string ImgPath { get; set; }
    }
}
