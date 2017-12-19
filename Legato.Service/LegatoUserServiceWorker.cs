using System;
using Ninject;
using Legato.Service.Interfaces;
using Legato.Service.ReturnTypes;
using Legato.ServiceDAL.Interfaces;


namespace Legato.Service
{
    public class LegatoUserServiceWorker : ILegatoUserServiceWorker
    {
        private IUserRepository _userRepository;

        [Inject]
        public LegatoUserServiceWorker(IUserRepository userRepo)
        {
            _userRepository = userRepo;
        }

        public bool FindUser(string username, string password)
        {
            return _userRepository.FindUser(username, password);
        }

        public bool AddToken(string token, int expireMinutes)
        {
            try
            {
                _userRepository.AddTokenToStorage(token, expireMinutes);
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

        public bool BanToken(string token)
        {
            try
            {
                _userRepository.BanUsedToken(token);
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
    }
}