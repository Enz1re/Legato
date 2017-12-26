using System;
using Ninject;
using System.Linq;
using Legato.DAL.Models;
using Legato.BL.Interfaces;
using Legato.DAL.Interfaces;
using System.Collections.Generic;
using Legato.MiddlewareContracts;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL.Workers
{
    public class LegatoUserBLWorker : ILegatoUserBLWorker
    {
        private IUserRepository _userRepository;

        [Inject]
        public LegatoUserBLWorker(IUserRepository userRepo)
        {
            _userRepository = userRepo;
        }
        
        public IEnumerable<UserDataModel> GetUsers()
        {
            return MiddlewareMappings.Map<List<UserDataModel>>(_userRepository.GetUsers().Where(u => u.UserRole.RoleName.ToLower() != "superuser").ToList());
        }

        public bool FindUser(string username)
        {
            return _userRepository.GetUser(username) != null;
        }

        public bool FindUser(string username, string password)
        {
            return _userRepository.GetUser(username, password) != null;
        }

        public void AddToken(string token, string issuedTo, int expireMinutes)
        {
            _userRepository.AddToken(token, issuedTo, expireMinutes);
        }

        public void RemoveToken(string token)
        {
            _userRepository.RemoveToken(token);
        }

        public void BanUser(string token)
        {
            _userRepository.BanUser(token);
        }

        public bool IsTokenValid(string token)
        {
            return _userRepository.IsTokenValid(token);
        }

        public bool IsTokenBanned(string token)
        {
            return _userRepository.IsTokenBanned(token);
        }

        public void RemoveExpiredTokens()
        {
            _userRepository.RemoveExpiredTokens();
        }

        public string GetUserRole(string username)
        {
            var user = _userRepository.GetUser(username);
            if (user != null)
            {
                return user.UserRole.RoleName;
            }
            else
            {
                throw new ArgumentException(DAL.Constants.Messages.NotFound($@"User '{username}'"), nameof(username));
            }
        }

        public IEnumerable<string> GetUserClaims(string username)
        {
            var user = _userRepository.GetUser(username);
            if (user != null)
            {
                return user.UserRole.UserClaims.Select(claim => claim.ClaimName);
            }
            else
            {
                throw new ArgumentException(DAL.Constants.Messages.NotFound($@"User '{username}'"), nameof(username));
            }
        }

        public void AddClaim(string username, string userClaim)
        {
            _userRepository.AddClaim(username, new UserClaim { ClaimName = userClaim });
        }

        public void AddCompromisedAttempt(CompromisedAttemptDataModel attempt)
        {
            _userRepository.AddCompromisedAttempt(MiddlewareMappings.Map<CompromisedAttemptModel>(attempt));
        }

        public IEnumerable<CompromisedAttemptDataModel> GetCompromisedAttempts()
        {
            return MiddlewareMappings.Map<List<CompromisedAttemptDataModel>>(_userRepository.GetCompromisedAttempts().ToList());
        }

        public void RemoveCompromisedAttempts(int[] ids)
        {
            var attempts = _userRepository.GetCompromisedAttempts().Where(attempt => ids.Contains(attempt.AttemptId)).ToArray();

            _userRepository.RemoveCompromisedAttempts(MiddlewareMappings.Map<CompromisedAttemptModel[]>(attempts));
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _userRepository.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
