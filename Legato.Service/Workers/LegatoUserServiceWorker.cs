using System;
using Ninject;
using Legato.ServiceDAL;
using Legato.Service.Interfaces;
using System.Collections.Generic;
using Legato.Service.ReturnTypes;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.ViewModels;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.Service.Workers
{
    public class LegatoUserServiceWorker : ILegatoUserServiceWorker
    {
        private IUserRepository _userRepository;

        [Inject]
        public LegatoUserServiceWorker(IUserRepository userRepo)
        {
            _userRepository = userRepo;
        }

        public UserList GetUsers(int lowerBound, int upperBound)
        {
            return new UserList
            {
                Users = ServiceMappings.Map<List<UserViewModel>>(_userRepository.GetUsers(lowerBound, upperBound))
            };
        }

        public bool FindUser(string username)
        {
            return _userRepository.FindUser(username);
        }

        public bool FindUser(string username, string password)
        {
            return _userRepository.FindUser(username, password);
        }

        public bool AddToken(string token, string username, int expireMinutes)
        {
            try
            {
                _userRepository.AddTokenToStorage(token, username, expireMinutes);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool RemoveToken(string token)
        {
            try
            {
                _userRepository.RemoveTokenFromStorage(token);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool BanUser(string username)
        {
            try
            {
                _userRepository.BanUserSession(username);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool IsTokenActive(string token)
        {
            return _userRepository.IsTokenAvailable(token);
        }

        public bool IsTokenBanned(string token)
        {
            return _userRepository.IsTokenBanned(token);
        }

        public string GetUserRole(string username)
        {
            return _userRepository.GetUserRole(username);
        }

        public ClaimList GetClaims(string username)
        {
            return new ClaimList
            {
                UserClaims = _userRepository.GetUserClaims(username)
            };
        }

        public bool AddClaim(string username, string claimName)
        {
            try
            {
                _userRepository.AddClaim(username, claimName);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool HasClaim(string username, string claimName)
        {
            return _userRepository.HasClaim(username, claimName);
        }

        public void AddCompromisedAttempt(CompromisedAttemptViewModel attempt)
        {
            _userRepository.AddCompromisedAttempt(ServiceMappings.Map<CompromisedAttemptDataModel>(attempt));
        }

        public CompromisedAttemptList GetCompromisedAttempts()
        {
            return new CompromisedAttemptList
            {
                CompromisedAttempts = ServiceMappings.Map<List<CompromisedAttemptViewModel>>(_userRepository.GetCompormisedAttempts())
            };
        }

        public void RemoveCompromisedAttempts(int[] attemptIds)
        {
            _userRepository.RemoveCompromisedAttempts(attemptIds);
        }
    }
}