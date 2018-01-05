using Legato.Service.ReturnTypes;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Interfaces
{
    public interface ILegatoUserManager
    {
        UserList GetUsers(int lowerBound, int upperBound);

        bool FindUser(string username);

        bool FindUser(string username, string password);

        bool BanUser(string token);

        string GetUserRole(string username);

        ClaimsViewModel GetClaims(string username);

        bool AddClaim(string username, string claimName);

        bool HasClaim(string username, string claimName);
    }
}
