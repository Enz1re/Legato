using System;
using Ninject;
using Legato.ServiceDAL;
using Legato.Service.Interfaces;
using Legato.Service.ReturnTypes;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Workers
{
    public class LegatoUserManager : ILegatoUserManager
    {
        private IUserRepository _userRepository;

        [Inject]
        public LegatoUserManager(IUserRepository userRepo)
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

        public bool BanUser(string username)
        {
            try
            {
                _userRepository.BanUserSession(username);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string GetUserRole(string username)
        {
            return _userRepository.GetUserRole(username);
        }

        public ClaimsViewModel GetClaims(string username)
        {
            return ServiceMappings.Map<ClaimsViewModel>(_userRepository.GetUserClaims(username));
        }

        public bool AddClaim(string username, string claimName)
        {
            try
            {
                _userRepository.AddClaim(username, claimName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool HasClaim(string username, string claimName)
        {
            return _userRepository.HasClaim(username, claimName);
        }
    }
}