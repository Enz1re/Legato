using System.Runtime.Serialization;


namespace Legato.MiddlewareContracts.DataContracts
{
    [DataContract]
    [KnownType(typeof(AcousticClassicalGuitarDataModel))]
    [KnownType(typeof(AcousticWesternGuitarDataModel))]
    [KnownType(typeof(ElectricGuitarDataModel))]
    [KnownType(typeof(BassGuitarDataModel))]
    public abstract class GuitarDataModel
    {
        [DataMember]
        public VendorDataModel Vendor { get; set; }

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
