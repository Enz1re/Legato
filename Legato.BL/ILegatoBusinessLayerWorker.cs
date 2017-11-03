using System;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL
{
    public interface ILegatoBusinessLayerWorker : IDisposable
    {
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<string> GetAcousticClassicalGuitarVendors();

        int GetAcousticClassicalGuitarAmount();

        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<string> GetAcousticWesternGuitarVendors();

        int GetAcousticWesternGuitarAmount();

        IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<string> GetElectricGuitarVendors();

        int GetElectriGuitarAmount();

        IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<string> GetBassGuitarVendors();

        int GetBassGuitarAmount();

        ILegatoBusinessLayerWorker Get();
    }
}
