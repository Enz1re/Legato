using System;
using Ninject;
using System.Linq;
using Legato.DAL.Util;
using Legato.DAL.Models;
using Legato.DAL.Constants;
using Legato.DAL.Interfaces;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;


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

        public IEnumerable<UserModel> GetUsers()
        {
            return _context.Users.ToList();
        }

        public UserModel GetUser(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }

        public UserModel GetUser(string username, string passwordHash)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username && u.EncryptedPassword == passwordHash);
        }

        public void AddToken(string token, string issuedTo, int expireMinutes)
        {
            var s = token.Length;
            ChangeUserAuthStatus(issuedTo, true);
            _context.TokenStorage.Add(new TokenModel { Token = token, IssuedTo = issuedTo, Expiry = Constants.Constants.Now().AddMinutes(expireMinutes) });
            _context.SaveChanges();
        }

        public void RemoveToken(string token)
        {
            var selectedToken = _context.TokenStorage.FirstOrDefault(t => t.Token == token);
            if (selectedToken != null)
            {
                ChangeUserAuthStatus(selectedToken.IssuedTo, false);
                _context.TokenStorage.Remove(selectedToken);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException(Messages.NotFound($@"Token '{token}'"), nameof(token));
            }
        }

        public bool IsTokenValid(string token)
        {
            return _context.TokenStorage.FirstOrDefault(t => t.Token == token) != null;
        }

        public bool IsTokenBanned(string token)
        {
            return _context.BannedTokens.FirstOrDefault(t => t.Token == token) != null;
        }

        public void BanUser(string username)
        {
            try
            {
                var selectedToken = _context.TokenStorage.FirstOrDefault(t => t.IssuedTo == username);
                if (selectedToken != null)
                {
                    ChangeUserAuthStatus(username, false);
                    _context.SaveChanges();
                    _context.TokenStorage.Remove(selectedToken);
                    _context.SaveChanges();
                    _context.BannedTokens.Add(new BannedTokenModel { Token = selectedToken.Token });
                    _context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException(Messages.NotAuthenticated($@"User '{selectedToken.IssuedTo}'"), nameof(username));
                }
            }
            catch (DbEntityValidationException e)
            {
                throw e;
            }
        }

        public void RemoveExpiredTokens()
        {
            foreach (var token in _context.TokenStorage)
            {
                if (token.Expiry > Constants.Constants.Now())
                {
                    ChangeUserAuthStatus(token.IssuedTo, false);   
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
        
        private void ChangeUserAuthStatus(string username, bool status)
        {
            var selectedUser = GetUser(username);
            selectedUser.IsAuthenticated = status;
            _context.Users.AddOrUpdate(selectedUser);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
