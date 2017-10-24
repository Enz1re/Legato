using System;


namespace Legato.DAL.Interfaces
{
    public interface IGuitarUnitOfWork : IDisposable
    {
        IAcousticClassicalGuitarRepository ClassicAcousticGuitars { get; }

        IAcousticWesternGuitarRepository WesternAcousticGuitars { get; }

        IBassGuitarRepository BassGuitars { get; }

        IElectricGuitarRepository ElectricGuitars { get; }

        void Commit();
    }
}
