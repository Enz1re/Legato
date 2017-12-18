using System;
using System.Collections.Generic;


namespace Legato.BL.Interfaces
{
    public interface ILegatoUserBLWorker : IDisposable
    {
        bool FindUser(string username, string password);

        void AddToken(string token, int expireMinutes);

        void RemoveToken(string token);

        void BanToken(string token);

        IEnumerable<string> GetUserClaims(string username);

        void AddClaim(string username, string userClaim);

        ILegatoUserBLWorker Get();
    }
}
