using System;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL
{
    public interface ILegatoBusinessLayerWorker : IDisposable
    {
        IEnumerable<GuitarDataModel> GetAllGuitars();

        IEnumerable<GuitarDataModel> GetGuitarsByPrice(short from, short to);

        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(short from, short to);

        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(short from, short to);

        IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(short from, short to);

        IEnumerable<ElectroGuitarDataModel> GetElectroGuitarsByPrice(short from, short to);

        IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars();

        IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars();

        IEnumerable<ElectroGuitarDataModel> GetAllElectroGuitars();

        IEnumerable<BassGuitarDataModel> GetAllBassGuitars();

        IEnumerable<GuitarDataModel> GetGuitarsByVendor(string vendor);

        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendor(string vendor);

        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendor(string vendor);

        IEnumerable<ElectroGuitarDataModel> GetElectroGuitarsByVendor(string vendor);

        IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendor(string vendor);

        ILegatoBusinessLayerWorker Get();
    }
}
