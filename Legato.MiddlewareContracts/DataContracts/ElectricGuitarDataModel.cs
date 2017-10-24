using System.Runtime.Serialization;


namespace Legato.MiddlewareContracts.DataContracts
{
    [DataContract]
    public class ElectricGuitarDataModel : GuitarDataModel
    {
        [DataMember]
        public byte StringNumber { get; set; }

        [DataMember]
        public bool HasTremoloBar { get; set; }

        [DataMember]
        public string Soundbox { get; set; }

        [DataMember]
        public short StringCaliber { get; set; }
    }
}
