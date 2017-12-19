using System;
using Ninject;
using System.Linq;
using Legato.DAL.Util;
using Legato.DAL.Models;
using Legato.DAL.Constants;
using Legato.DAL.Interfaces;
using System.Collections.Generic;


namespace Legato.DAL.Repositories
{
    class UserRepository : IUserRepository
    {
        private IUserContext _context;

        [Inject]
        public UserRepository(IUserContext context)
        {
            _context = context;
        }

        public UserModel GetUser(string username, string password)
        {
            try
            {
                var passwordHash = Hashing.HashData(password);
                return _context.Users.FirstOrDefault(u => u.Username == username && u.EncryptedPassword == passwordHash);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void AddToken(string token, int expireMinutes)
        {
            _context.TokenStorage.Add(new TokenModel { Token = token, Expiry = DateTime.Now.AddMinutes(expireMinutes) });
            _context.SaveChanges();
        }

        public void RemoveToken(string token)
        {
            var selectedToken = _context.TokenStorage.FirstOrDefault(t => t.Token == token);
            if (selectedToken != null)
            {
                _context.TokenStorage.Remove(selectedToken);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException(Messages.NotFound($@"Token '{token}'"), nameof(token));
            }
        }

        public void BanToken(string token)
        {
            var selectedToken = _context.TokenStorage.FirstOrDefault(t => t.Token == token);
            if (selectedToken != null)
            {
                _context.TokenStorage.Remove(selectedToken);
                _context.BannedTokens.Add(new BannedTokenModel { Token = selectedToken.Token });
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException(Messages.NotFound($@"Token '{token}'"), nameof(token));
            }
        }

        public bool IsTokenPresentInStorage(string token)
        {
            return _context.TokenStorage.FirstOrDefault(t => t.Token == token) != null;
        }

        public bool IsTokenBanned(string token)
        {
            return _context.BannedTokens.FirstOrDefault(t => t.Token == token) != null;
        }

        public IEnumerable<UserClaim> GetUserClaims(string username)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                return user.UserRole.UserClaims;
            }
            else
            {
                throw new ArgumentException(Messages.NotFound($@"User '{username}'"), nameof(username));
            }
        }
        
        public void AddClaim(string username, UserClaim userClaim)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                if (!user.UserRole.UserClaims.Contains(userClaim, new UserClaimEqualityComparer()))
                {
                    user.UserRole.UserClaims.Add(userClaim);
                    _context.SaveChanges();
                }
            }
            else
            {
                throw new ArgumentException(Messages.NotFound($@"User '{username}'"), nameof(username));
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
