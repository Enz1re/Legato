using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Interfaces
{
    public interface IServiceRepositoryProvider
    {
        IGuitarRepository<AcousticClassicalGuitarDataModel> AcousticClassicalGuitarRepository { get; }

        IGuitarRepository<AcousticWesternGuitarDataModel> AcousticWesternGuitarRepository { get; }

        IGuitarRepository<ElectricGuitarDataModel> ElectricGuitarRepository { get; }

        IGuitarRepository<BassGuitarDataModel> BassGuitarRepository { get; }
    }
}
