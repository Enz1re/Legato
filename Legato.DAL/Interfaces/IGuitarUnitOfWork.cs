using System;
using Legato.DAL.Models;


namespace Legato.DAL.Interfaces
{
    public interface IGuitarUnitOfWork : IDisposable
    {
        IGuitarRepository<AcousticClassicalGuitarModel> ClassicAcousticGuitars { get; }

        IGuitarRepository<AcousticWesternGuitarModel> WesternAcousticGuitars { get; }

        IGuitarRepository<BassGuitarModel> BassGuitars { get; }

        IGuitarRepository<ElectricGuitarModel> ElectricGuitars { get; }

        void Commit();
    }
}
