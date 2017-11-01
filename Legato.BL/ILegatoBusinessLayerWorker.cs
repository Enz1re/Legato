using System;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL
{
    public interface ILegatoBusinessLayerWorker : IDisposable
    {
        IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars(int lowerBound, int upperBound);

        IEnumerable<string> GetAcousticClassicalGuitarVendors();

        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(int from, int to, int lowerBound, int upperBound);

        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendors(string[] vendors, int lowerBound, int upperBound);

        int GetAcousticClassicalGuitarAmount();

        IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars(int lowerBound, int upperBound);

        IEnumerable<string> GetAcousticWesternGuitarVendors();

        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(int from, int to, int lowerBound, int upperBound);

        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendors(string[] vendors, int lowerBound, int upperBound);

        int GetAcousticWesternGuitarAmount();

        IEnumerable<ElectricGuitarDataModel> GetAllElectricGuitars(int lowerBound, int upperBound);

        IEnumerable<string> GetElectricGuitarVendors();

        IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByPrice(int from, int to, int lowerBound, int upperBound);

        IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByVendors(string[] vendors, int lowerBound, int upperBound);

        int GetElectriGuitarAmount();

        IEnumerable<BassGuitarDataModel> GetAllBassGuitars(int lowerBound, int upperBound);

        IEnumerable<string> GetBassGuitarVendors();

        IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(int from, int to, int lowerBound, int upperBound);

        IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendors(string[] vendors, int lowerBound, int upperBound);

        int GetBassGuitarAmount();

        ILegatoBusinessLayerWorker Get();
    }
}
