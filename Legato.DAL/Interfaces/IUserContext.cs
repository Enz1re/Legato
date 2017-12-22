using System;
using Legato.DAL.Models;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;


namespace Legato.DAL.Interfaces
{
    interface IUserContext : IDisposable
    {
        DbSet<UserRole> UserRoles { get; set; }

        DbSet<UserClaim> UserClaims { get; set; }

        DbSet<UserModel> Users { get; set; }

        DbSet<TokenModel> TokenStorage { get; set; }

        DbSet<BannedTokenModel> BannedTokens { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync();

        DbEntityEntry Entry(object entity);

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
