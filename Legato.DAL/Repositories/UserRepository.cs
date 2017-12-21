using System;
using Ninject;
using System.Linq;
using Legato.DAL.Util;
using Legato.DAL.Models;
using Legato.DAL.Constants;
using Legato.DAL.Interfaces;


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

        public UserModel GetUser(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }

        public UserModel GetUser(string username, string password)
        {
            var passwordHash = Hashing.HashData(password);
            return _context.Users.FirstOrDefault(u => u.Username == username && u.EncryptedPassword == passwordHash);
        }

        public void AddToken(string token, int expireMinutes)
        {
            var s = token.Length;
            _context.TokenStorage.Add(new TokenModel { Token = token, Expiry = Constants.Constants.Now().AddMinutes(expireMinutes) });
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
        
        public bool IsTokenBanned(string token)
        {
            return _context.BannedTokens.FirstOrDefault(t => t.Token == token) != null;
        }

        public void RemoveExpiredTokens()
        {
            foreach (var token in _context.TokenStorage)
            {
                if (token.Expiry > Constants.Constants.Now())
                {
                    RemoveToken(token.Token);
                }
            }

            _context.SaveChanges();
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
