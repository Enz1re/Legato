using System;
using Legato.DAL.Models;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;


namespace Legato.DAL.Interfaces
{
    public interface ILegatoContext : IDisposable
    {
        DbSet<AcousticClassicalGuitarModel> ClassicalAcousticGuitars { get; set; }

        DbSet<AcousticWesternGuitarModel> WesternAcousticGuitars { get; set; }

        DbSet<BassGuitarModel> BassGuitars { get; set; }

        DbSet<ElectricGuitarModel> ElectricGuitars { get; set; }

        DbSet<VendorModel> Vendors { get; set; }

        DbSet<UserRole> UserRoles { get; set; }

        DbSet<UserClaim> UserClaims { get; set; }

        DbSet<UserModel> Users { get; set; }

        DbSet<TokenModel> TokenStorage { get; set; }

        DbSet<BannedTokenModel> BannedTokens { get; set; }

        DbSet<CompromisedAttemptModel> CompromisedAttempts { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync();

        DbEntityEntry Entry(object entity);

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
