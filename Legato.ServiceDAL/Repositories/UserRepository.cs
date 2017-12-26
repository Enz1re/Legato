using Ninject;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.Middleware;
using Legato.MiddlewareContracts.DataContracts;


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

        public IEnumerable<UserDataModel> GetUsers()
        {
            return _client.GetUsers();
        }

        public bool FindUser(string username)
        {
            return _client.FindUserByUsername(username);
        }

        public bool FindUser(string username, string password)
        {
            return _client.FindUser(username, password);
        }

        public void AddTokenToStorage(string token, string username, int expireMinutes)
        {
            _client.AddTokenToStorage(token, username, expireMinutes);
        }

        public void RemoveTokenFromStorage(string token)
        {
            _client.RemoveTokenFromStorage(token);
        }

        public void BanUserSession(string token)
        {
            _client.BanUser(token);
        }

        public bool IsTokenAvailable(string token)
        {
            return _client.IsTokenValid(token);
        }

        public bool IsTokenBanned(string token)
        {
            return _client.IsTokenBanned(token);
        }

        public void RemoveExpiredTokens()
        {
            _client.RemoveExpiredTokens();
        }

        public string GetUserRole(string username)
        {
            return _client.GetUserRole(username);
        }

        public IEnumerable<string> GetUserClaims(string username)
        {
            return _client.GetUserClaims(username);
        }

        public void AddClaim(string username, string claimName)
        {
            _client.AddClaim(username, claimName);
        }

        public void AddCompromisedAttempt(CompromisedAttemptDataModel attempt)
        {
            _client.AddCompromisedAttempt(attempt);
        }

        public IEnumerable<CompromisedAttemptDataModel> GetCompormisedAttempts()
        {
            return _client.GetCompromisedAttempts();
        }

        public void RemoveCompromisedAttempts(int[] attemptIds)
        {
            _client.RemoveCompromisedAttempts(attemptIds);
        }
    }
}
