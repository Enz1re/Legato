using System.Collections.Generic;


namespace Legato.Service.ReturnTypes
{
    public class ClaimList
    {
        public IEnumerable<string> UserClaims { get; set; }
    }
}