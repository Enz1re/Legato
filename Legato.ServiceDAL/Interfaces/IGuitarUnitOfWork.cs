﻿using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL.Interfaces
{
    public interface IGuitarUnitOfWork
    {
        IGuitarRepository<GuitarDataModel> GuitarsCommon { get; }

        IGuitarRepository<AcousticClassicalGuitarDataModel> ClassicAcousticGuitars { get; }

        IGuitarRepository<AcousticWesternGuitarDataModel> WesternAcousticGuitars { get; }

        IGuitarRepository<ElectroGuitarDataModel> ElectroGuitars { get; }

        IGuitarRepository<BassGuitarDataModel> BassGuitars { get; }
    }
}