namespace Legato.ServiceDAL.ViewModels
{
    public abstract class GuitarViewModel
    {
        public string Vendor { get; set; }

        public string Model { get; set; }

        public short Mensura { get; set; }

        public int StockPrice { get; set; }
    }
}
