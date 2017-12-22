using System;
using Legato.DAL.Models;
using System.Collections.Generic;


namespace Legato.DAL.Interfaces
{
    public interface IUserRepository : IDisposable
    {
        IEnumerable<UserModel> GetUsers();

        UserModel GetUser(string username);

        UserModel GetUser(string username, string passwordHash);

        void AddToken(string token, string issuedTo, int expireMinutes);

        void RemoveToken(string token);

        bool IsTokenValid(string token);
        
        bool IsTokenBanned(string token);

        void BanUser(string username);
        
        void RemoveExpiredTokens();

        void AddClaim(string username, UserClaim userClaim);
    }
}
