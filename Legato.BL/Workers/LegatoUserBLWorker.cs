﻿using Ninject;
using System.Linq;
using Legato.DAL.Models;
using Legato.BL.Interfaces;
using Legato.DAL.Interfaces;
using System.Collections.Generic;


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

        public bool FindUser(string username)
        {
            return _userRepository.GetUser(username) != null;
        }

        public bool FindUser(string username, string password)
        {
            return _userRepository.GetUser(username, password) != null;
        }

        public void AddToken(string token, int expireMinutes)
        {
            _userRepository.AddToken(token, expireMinutes);
        }

        public void RemoveToken(string token)
        {
            _userRepository.RemoveToken(token);
        }

        public void BanToken(string token)
        {
            _userRepository.BanToken(token);
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

        public IEnumerable<string> GetUserClaims(string username)
        {
            return _userRepository.GetUserClaims(username).Select(c => c.ClaimName);
        }

        public void AddClaim(string username, string userClaim)
        {
            _userRepository.AddClaim(username, new UserClaim { ClaimName = userClaim });
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
