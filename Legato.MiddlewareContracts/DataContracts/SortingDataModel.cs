namespace Legato.MiddlewareContracts.DataContracts
{
    public enum SortHeader
    {
        Price,
        Vendor
    }

    public enum SortDirection
    {
        Ascending,
        Descending
    }

    public class SortingDataModel
    {
        public SortHeader SortHeader { get; set; }

        public SortDirection SortDirection { get; set; }
    }
}
