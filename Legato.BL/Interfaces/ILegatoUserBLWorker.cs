using System;
using System.Collections.Generic;


namespace Legato.BL.Interfaces
{
    public interface ILegatoUserBLWorker : IDisposable
    {
        bool FindUser(string username);

        bool FindUser(string username, string password);

        void AddToken(string token, int expireMinutes);

        void RemoveToken(string token);

        void BanToken(string token);

        bool IsTokenValid(string token);

        bool IsTokenBanned(string token);

        void RemoveExpiredTokens();

        IEnumerable<string> GetUserClaims(string username);

        void AddClaim(string username, string userClaim);
    }
}
