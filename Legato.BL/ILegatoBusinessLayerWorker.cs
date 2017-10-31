using System;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL
{
    public interface ILegatoBusinessLayerWorker : IDisposable
    {
        IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars();

        IEnumerable<VendorDataModel> GetAcousticClassicalGuitarVendors();

        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(short from, short to);

        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendor(string vendor);

        IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars();

        IEnumerable<VendorDataModel> GetAcousticWesternGuitarVendors();

        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(short from, short to);

        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendor(string vendor);

        IEnumerable<ElectricGuitarDataModel> GetAllElectricGuitars();

        IEnumerable<VendorDataModel> GetElectricGuitarVendors();

        IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByPrice(short from, short to);

        IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByVendor(string vendor);

        IEnumerable<BassGuitarDataModel> GetAllBassGuitars();

        IEnumerable<VendorDataModel> GetBassGuitarVendors();

        IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(short from, short to);

        IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendor(string vendor);

        ILegatoBusinessLayerWorker Get();
    }
}
