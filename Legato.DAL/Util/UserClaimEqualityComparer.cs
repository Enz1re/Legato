using Legato.DAL.Models;
using System.Collections.Generic;


namespace Legato.DAL.Util
{
    class UserClaimEqualityComparer : EqualityComparer<UserClaim>
    {
        public override bool Equals(UserClaim x, UserClaim y)
        {
            return x.ClaimName == y.ClaimName;
        }

        public override int GetHashCode(UserClaim obj)
        {
            return obj.ClaimName.GetHashCode();
        }
    }
}
