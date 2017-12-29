using System;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL.Interfaces
{
    public interface ILegatoUserBLWorker : IDisposable
    {
        IEnumerable<UserDataModel> GetUsers(int lowerBound, int upperBound);

        bool FindUser(string username);

        bool FindUser(string username, string password);

        void AddToken(string token, string issuedTo, int expireMinutes);

        void RemoveToken(string token);

        void BanUser(string username);

        bool IsTokenValid(string token);

        bool IsTokenBanned(string token);

        void RemoveExpiredTokens();

        string GetUserRole(string username);

        IEnumerable<string> GetUserClaims(string username);

        void AddClaim(string username, string userClaim);

        bool ValidateClaim(string username, string claimName);

        void AddCompromisedAttempt(CompromisedAttemptDataModel attempt);

        IEnumerable<CompromisedAttemptDataModel> GetCompromisedAttempts();

        void RemoveCompromisedAttempts(int[] ids);
    }
}
