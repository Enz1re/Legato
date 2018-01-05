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
        private ILegatoUserManager _userManager;

        [Inject]
        public LegatoUserServiceWorker(IUserRepository userRepo, ILegatoUserManager userManager)
        {
            _userRepository = userRepo;
            _userManager = userManager;
        }

        public bool AddToken(string token, string username, int expireMinutes)
        {
            try
            {
                _userRepository.AddTokenToStorage(token, username, expireMinutes);
                return true;
            }
            catch (Exception)
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
            catch (Exception)
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
        
        public ILegatoUserManager GetUserManager()
        {
            return _userManager;
        }
    }
}