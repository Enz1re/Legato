using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Interfaces
{
    public interface IGuitarUnitOfWork
    {
        IGuitarRepository<AcousticClassicalGuitarDataModel> ClassicAcousticGuitars { get; }

        IGuitarRepository<AcousticWesternGuitarDataModel> WesternAcousticGuitars { get; }

        IGuitarRepository<ElectricGuitarDataModel> ElectricGuitars { get; }

        IGuitarRepository<BassGuitarDataModel> BassGuitars { get; }
    }
}
