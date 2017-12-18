using System.Data.Entity;
using Legato.DAL.Interfaces;


namespace Legato.DAL.Models
{
    public class UserContext : DbContext, IUserContext
    {
        public UserContext(string connectionString) : base(connectionString)
        {
        }

        public DbSet<UserClaim> UserClaims { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<TokenModel> TokenStorage { get; set; }

        public DbSet<TokenModel> BannedTokens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TokenModel>()
                .Map(m => m.ToTable("TokenStorage"))
                .Map(m => m.ToTable("BannedTokens"));

            Database.SetInitializer(new UserDbInitializer());

            base.OnModelCreating(modelBuilder);
        }
    }
}
