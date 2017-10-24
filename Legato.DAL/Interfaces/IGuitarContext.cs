using System;
using Legato.DAL.Models;
using System.Data.Entity;
using System.Threading.Tasks;


namespace Legato.DAL.Interfaces
{
    public interface IGuitarContext : IDisposable
    {
        DbSet<AcousticClassicalGuitarModel> ClassicAcousticGuitars { get; set; }

        DbSet<AcousticWesternGuitarModel> WesternAcousticGuitars { get; set; }

        DbSet<BassGuitarModel> BassGuitars { get; set; }

        DbSet<ElectricGuitarModel> ElectricGuitars { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}
