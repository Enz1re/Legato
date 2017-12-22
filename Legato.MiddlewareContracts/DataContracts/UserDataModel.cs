using System.Runtime.Serialization;


namespace Legato.MiddlewareContracts.DataContracts
{
    [DataContract]
    public class UserDataModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string EncryptedPassword { get; set; }

        [DataMember]
        public bool IsAuthenticated { get; set; }

        [DataMember]
        public string UserRole { get; set; }
    }
}
