using System.Runtime.Serialization;


namespace Legato.MiddlewareContracts.DataContracts
{
    [DataContract]
    public class AcousticWesternGuitarDataModel : GuitarDataModel
    {
        [DataMember]
        public byte StringNumber { get; set; }

        [DataMember]
        public short StringCaliber { get; set; }
    }
}
