using System;


namespace Legato.DAL.Interfaces
{
    public interface IRepositoryProvider : IDisposable
    {
        IAcousticClassicalGuitarRepository AcousticClassicalGuitarRepository { get; }

        IAcousticWesternGuitarRepository AcousticWesternGuitarRepository { get; }

        IBassGuitarRepository BassGuitarRepository { get; }

        IElectricGuitarRepository ElectricGuitarRepository { get; }
    }
}
