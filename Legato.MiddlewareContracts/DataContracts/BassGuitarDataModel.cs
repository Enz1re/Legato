using System.Runtime.Serialization;


namespace Legato.MiddlewareContracts.DataContracts
{
    [DataContract]
    public class BassGuitarDataModel : GuitarDataModel
    {
        [DataMember]
        public byte StringNumber { get; set; }

        [DataMember]
        public string Soundbox { get; set; }
    }
}
