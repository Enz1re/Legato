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
        private ILegatoContext _context;

        [Inject]
        public UserRepository(ILegatoContext context)
        {
            _context = context;
        }

        public IQueryable<UserModel> GetUsers()
        {
            return _context.Users.OrderBy(u => u.Id);
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
            var selectedToken = _context.TokenStorage.FirstOrDefault(t => t.IssuedTo == username);
            if (selectedToken != null)
            {
                ChangeUserAuthStatus(username, false);
                _context.TokenStorage.Remove(selectedToken);
                _context.BannedTokens.Add(new BannedTokenModel { Token = selectedToken.Token });
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException(Messages.NotAuthenticated($@"User '{selectedToken.IssuedTo}'"), nameof(username));
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
            var user = GetUser(username);
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

        public bool ValidateClaim(string username, string claimName)
        {
            var user = GetUser(username);
            if (user != null)
            {
                return user.UserRole.UserClaims.Contains(new UserClaim { ClaimName = claimName }, new UserClaimEqualityComparer());
            }
            else
            {
                throw new ArgumentException(Messages.NotFound($@"User '{username}'"), nameof(username));
            }
        }

        public void AddCompromisedAttempt(CompromisedAttemptModel attempt)
        {
            _context.CompromisedAttempts.Add(attempt);
            _context.SaveChanges();
        }

        public IQueryable<CompromisedAttemptModel> GetCompromisedAttempts()
        {
            return _context.CompromisedAttempts.OrderBy(u => u.AttemptId);
        }

        public void RemoveCompromisedAttempts(CompromisedAttemptModel[] attempts)
        {
            foreach (var attempt in attempts)
            {
                _context.CompromisedAttempts.Remove(attempt);
            }

            _context.SaveChanges();
        }

        private void ChangeUserAuthStatus(string username, bool status)
        {
            var selectedUser = GetUser(username);
            selectedUser.IsAuthenticated = status;
            _context.Entry(selectedUser).Reference(u => u.UserRole).Load();
            _context.Users.Attach(selectedUser);
            _context.Entry(selectedUser).Property(u => u.IsAuthenticated).IsModified = true;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
