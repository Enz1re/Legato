using System;
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

        public DbSet<BannedTokenModel> BannedTokens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>()
                .HasMany(role => role.UserClaims)
                .WithMany(claim => claim.UserRoles)
                .Map(u =>
                    {
                        u.MapLeftKey("UserRoleRefId");
                        u.MapRightKey("UserClaimsRefId");
                        u.ToTable("UserRoles");
                    });

            Database.SetInitializer(new UserDbInitializer());
            base.OnModelCreating(modelBuilder);
        }
    }
}
