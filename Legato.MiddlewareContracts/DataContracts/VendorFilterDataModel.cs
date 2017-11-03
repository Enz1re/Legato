using System.Runtime.Serialization;


namespace Legato.MiddlewareContracts.DataContracts
{
    [DataContract]
    public class VendorFilterDataModel
    {
        [DataMember]
        public string[] Vendors { get; set; }
    }
}
