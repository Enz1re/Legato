using System;
using Legato.DAL.Models;


namespace Legato.DAL.Interfaces
{
    public interface IRepositoryProvider : IDisposable
    {
        IGuitarRepository<AcousticClassicalGuitarModel> AcousticClassicalGuitarRepository { get; }

        IGuitarRepository<AcousticWesternGuitarModel> AcousticWesternGuitarRepository { get; }

        IGuitarRepository<BassGuitarModel> BassGuitarRepository { get; }

        IGuitarRepository<ElectricGuitarModel> ElectricGuitarRepository { get; }
    }
}
