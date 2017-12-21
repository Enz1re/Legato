using System.Collections.Generic;


namespace Legato.ServiceDAL.Interfaces
{
    public interface IUserRepository
    {
        bool FindUser(string username);

        bool FindUser(string username, string password);

        void AddTokenToStorage(string token, int expireMinutes);

        void RemoveTokenFromStorage(string token);

        void BanUsedToken(string token);

        bool IsTokenAvailable(string token);

        bool IsTokenBanned(string token);

        string GetUserRole(string username);

        IEnumerable<string> GetUserClaims(string username);

        void AddClaim(string username, string claimName);
    }
}
