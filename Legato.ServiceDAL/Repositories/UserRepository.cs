using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.Middleware;


namespace Legato.ServiceDAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private LegatoMiddlewareClient _client;

        [Inject]
        public UserRepository(LegatoMiddlewareClient client)
        {
            _client = client;
        }

        public bool FindUser(string username)
        {
            return _client.FindUserByUsername(username);
        }

        public bool FindUser(string username, string password)
        {
            return _client.FindUser(username, password);
        }

        public void AddTokenToStorage(string token, int expireMinutes)
        {
            _client.AddTokenToStorage(token, expireMinutes);
        }

        public void RemoveTokenFromStorage(string token)
        {
            _client.RemoveTokenFromStorage(token);
        }

        public void BanUsedToken(string token)
        {
            _client.BanToken(token);
        }

        public bool IsTokenAvailable(string token)
        {
            return _client.IsTokenValid(token);
        }

        public bool IsTokenBanned(string token)
        {
            return _client.IsTokenBanned(token);
        }

        public IEnumerable<string> GetUserClaims(string username)
        {
            return _client.GetUserClaims(username);
        }

        public void AddClaim(string username, string claimName)
        {
            _client.AddClaim(username, claimName);
        }
    }
}
