using System.Runtime.Serialization;


namespace Legato.MiddlewareContracts.DataContracts
{
    [DataContract]
    public class PriceFilterDataModel
    {
        [DataMember]
        public int? From { get; set; }

        [DataMember]
        public int? To { get; set; }
    }
}
