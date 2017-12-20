using System;
using Legato.DAL.Models;
using System.Collections.Generic;


namespace Legato.DAL.Interfaces
{
    public interface IUserRepository : IDisposable
    {
        UserModel GetUser(string username);

        UserModel GetUser(string username, string password);

        void AddToken(string token, int expireMinutes);

        void RemoveToken(string token);

        void BanToken(string token);

        bool IsTokenValid(string token);

        bool IsTokenBanned(string token);

        void RemoveExpiredTokens();

        IEnumerable<UserClaim> GetUserClaims(string username);

        void AddClaim(string username, UserClaim userClaim);
    }
}
