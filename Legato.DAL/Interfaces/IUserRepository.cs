using System;
using System.Linq;
using Legato.DAL.Models;


namespace Legato.DAL.Interfaces
{
    public interface IUserRepository : IDisposable
    {
        IQueryable<UserModel> GetUsers();

        UserModel GetUser(string username);

        UserModel GetUser(string username, string passwordHash);

        void AddToken(string token, string issuedTo, int expireMinutes);

        void RemoveToken(string token);

        bool IsTokenValid(string token);
        
        bool IsTokenBanned(string token);

        void BanUser(string username);
        
        void RemoveExpiredTokens();

        void AddClaim(string username, UserClaim userClaim);

        bool ValidateClaim(string username, string claimName);

        void AddCompromisedAttempt(CompromisedAttemptModel attempt);

        IQueryable<CompromisedAttemptModel> GetCompromisedAttempts();

        void RemoveCompromisedAttempts(CompromisedAttemptModel[] attempts);
    }
}
