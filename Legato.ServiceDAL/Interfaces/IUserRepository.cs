using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<UserDataModel> GetUsers();

        bool FindUser(string username);

        bool FindUser(string username, string password);

        void AddTokenToStorage(string token, string username, int expireMinutes);

        void RemoveTokenFromStorage(string token);

        void BanUserSession(string token);

        bool IsTokenAvailable(string token);

        bool IsTokenBanned(string token);

        void RemoveExpiredTokens();

        string GetUserRole(string username);

        IEnumerable<string> GetUserClaims(string username);

        void AddClaim(string username, string claimName);

        bool HasClaim(string username, string claimName);

        void AddCompromisedAttempt(CompromisedAttemptDataModel attempt);

        IEnumerable<CompromisedAttemptDataModel> GetCompormisedAttempts();

        void RemoveCompromisedAttempts(int[] attemptIds);
    }
}
