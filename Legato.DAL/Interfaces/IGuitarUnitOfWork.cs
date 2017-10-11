using System;


namespace Legato.DAL.Interfaces
{
    public interface IGuitarUnitOfWork : IDisposable
    {
        IAcousticClassicalGuitarRepository ClassicAcousticGuitars { get; }

        IAcousticWesternGuitarRepository WesternAcousticGuitars { get; }

        IBassGuitarRepository BassGuitars { get; }

        IElectroGuitarRepository ElectroGuitars { get; }

        void Commit();
    }
}
