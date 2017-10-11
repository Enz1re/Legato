namespace Legato.DAL.Interfaces
{
    public interface IRepositoryProvider
    {
        IAcousticClassicalGuitarRepository AcousticClassicalGuitarRepository { get; }

        IAcousticWesternGuitarRepository AcousticWesternGuitarRepository { get; }

        IBassGuitarRepository BassGuitarRepository { get; }

        IElectroGuitarRepository ElectroGuitarRepository { get; }
    }
}
