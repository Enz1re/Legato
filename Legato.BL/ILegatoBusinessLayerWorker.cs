using System;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL
{
    public interface ILegatoBusinessLayerWorker : IDisposable
    {
        IEnumerable<GuitarDataModel> GetAllGuitars();

        IEnumerable<string> GetAllVendors();

        IEnumerable<GuitarDataModel> GetGuitarsByPrice(short from, short to);

        IEnumerable<GuitarDataModel> GetGuitarsByVendor(string vendor);

        IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars();

        IEnumerable<string> GetAcousticClassicalGuitarVendors();

        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(short from, short to);

        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendor(string vendor);

        IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars();

        IEnumerable<string> GetAcousticWesternGuitarVendors();

        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(short from, short to);

        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendor(string vendor);

        IEnumerable<ElectricGuitarDataModel> GetAllElectricGuitars();

        IEnumerable<string> GetElectricGuitarVendors();

        IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByPrice(short from, short to);

        IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByVendor(string vendor);

        IEnumerable<BassGuitarDataModel> GetAllBassGuitars();

        IEnumerable<string> GetBassGuitarVendors();

        IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(short from, short to);

        IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendor(string vendor);

        ILegatoBusinessLayerWorker Get();
    }
}
