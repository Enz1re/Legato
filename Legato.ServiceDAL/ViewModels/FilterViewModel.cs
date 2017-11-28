namespace Legato.ServiceDAL.ViewModels
{
    public class FilterViewModel
    {
        public PriceFilterViewModel PriceFilter { get; set; }

        public VendorFilterViewModel VendorFilter { get; set; }

        public string[] SearchItems { get; set; }
    }
}
