using System.Runtime.Serialization;


namespace Legato.MiddlewareContracts.DataContracts
{
    [DataContract]
    public class AcousticClassicalGuitarDataModel : GuitarDataModel
    {
        [DataMember]
        public string StringType { get; }
    }
}
