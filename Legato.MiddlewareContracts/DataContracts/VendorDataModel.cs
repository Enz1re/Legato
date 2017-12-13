using System.Runtime.Serialization;


namespace Legato.MiddlewareContracts.DataContracts
{
    [DataContract]
    public class VendorDataModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
