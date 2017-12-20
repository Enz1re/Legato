using System.Data.Entity;
using Legato.DAL.Interfaces;


namespace Legato.DAL.Models
{
    public class GuitarContext : DbContext, IGuitarContext
    {
        public GuitarContext() : base(Constants.Constants.DefaultConnectionStringName)
        {
        }

        public GuitarContext(string connectionString) : base(connectionString)
        {
        }

        public DbSet<AcousticClassicalGuitarModel> ClassicalAcousticGuitars { get; set; }

        public DbSet<AcousticWesternGuitarModel> WesternAcousticGuitars { get; set; }
        
        public DbSet<BassGuitarModel> BassGuitars { get; set; }

        public DbSet<ElectricGuitarModel> ElectricGuitars { get; set; }

        public DbSet<VendorModel> Vendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DatabaseInitializer());
            base.OnModelCreating(modelBuilder);
        }
    }
}
