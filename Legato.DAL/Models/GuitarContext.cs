using System.Data.Entity;
using Legato.DAL.Interfaces;


namespace Legato.DAL.Models
{
    public class GuitarContext : DbContext, IGuitarContext
    {
        public GuitarContext(string connectionString) : base(connectionString)
        {
        }

        public DbSet<AcousticClassicalGuitarModel> ClassicAcousticGuitars { get; set; }

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
