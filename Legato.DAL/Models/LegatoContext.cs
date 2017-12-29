using System.Data.Entity;
using Legato.DAL.Interfaces;


namespace Legato.DAL.Models
{
    public class LegatoContext : DbContext, ILegatoContext
    {
        public LegatoContext() : base(Constants.Constants.DefaultConnectionStringName)
        {
        }

        public LegatoContext(string connectionString) : base(connectionString)
        {
        }

        public DbSet<AcousticClassicalGuitarModel> ClassicalAcousticGuitars { get; set; }

        public DbSet<AcousticWesternGuitarModel> WesternAcousticGuitars { get; set; }
        
        public DbSet<BassGuitarModel> BassGuitars { get; set; }

        public DbSet<ElectricGuitarModel> ElectricGuitars { get; set; }

        public DbSet<VendorModel> Vendors { get; set; }

        public DbSet<UserClaim> UserClaims { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<TokenModel> TokenStorage { get; set; }

        public DbSet<BannedTokenModel> BannedTokens { get; set; }

        public DbSet<CompromisedAttemptModel> CompromisedAttempts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DatabaseInitializer());
            base.OnModelCreating(modelBuilder);
        }
    }
}
