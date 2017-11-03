using System.Runtime.Serialization;


namespace Legato.MiddlewareContracts.DataContracts
{
    [DataContract]
    public class FilterDataModel
    {
        [DataMember]
        public PriceFilterDataModel PriceFilter { get; set; }

        [DataMember]
        public VendorFilterDataModel VendorFilter { get; set; }
    }
}
