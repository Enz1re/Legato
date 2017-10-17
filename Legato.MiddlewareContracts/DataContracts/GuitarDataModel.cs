using System.Runtime.Serialization;


namespace Legato.MiddlewareContracts.DataContracts
{
    [DataContract]
    public abstract class GuitarDataModel
    {
        [DataMember]
        public string Vendor { get; set; }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public short Mensura { get; set; }

        [DataMember]
        public int Price { get; set; }

        [DataMember]
        public string ImgPath { get; set; }
    }
}
