using Legato.Service.ReturnTypes;


namespace Legato.Service.Interfaces
{
    public interface ILegatoUserServiceWorker
    {
        UserList GetUsers();

        bool FindUser(string username);

        bool FindUser(string username, string password);

        bool AddToken(string token, string username, int expireMinutes);

        bool RemoveToken(string token);

        bool BanUser(string token);

        bool IsTokenActive(string token);

        bool IsTokenBanned(string token);

        string GetUserRole(string username);

        ClaimList GetClaims(string username);

        bool AddClaim(string username, string claimName);
    }
}
