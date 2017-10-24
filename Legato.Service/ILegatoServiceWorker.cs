using System;
using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service
{
    public interface ILegatoServiceWorker
    {
        IEnumerable<GuitarViewModel> GetAllGuitars();

        IEnumerable<string> GetAllVendors();

        IEnumerable<GuitarViewModel> GetGuitarsByPrice(short from, short to);

        IEnumerable<string> GetAcousticClassicalGuitarVendors();

        IEnumerable<AcousticClassicalGuitarViewModel> GetAcousticClassicalGuitarsByPrice(short from, short to);

        IEnumerable<string> GetAcousticWesternGuitarVendors();

        IEnumerable<AcousticWesternGuitarViewModel> GetAcousticWesternGuitarsByPrice(short from, short to);

        IEnumerable<BassGuitarViewModel> GetBassGuitarsByPrice(short from, short to);

        IEnumerable<string> GetElectricGuitarVendors();

        IEnumerable<ElectricGuitarViewModel> GetElectricGuitarsByPrice(short from, short to);

        IEnumerable<AcousticClassicalGuitarViewModel> GetAllAcousticClassicalGuitars();

        IEnumerable<AcousticWesternGuitarViewModel> GetAllAcousticWesternGuitars();

        IEnumerable<ElectricGuitarViewModel> GetAllElectricGuitars();

        IEnumerable<string> GetBassGuitarVendors();

        IEnumerable<BassGuitarViewModel> GetAllBassGuitars();

        IEnumerable<GuitarViewModel> GetGuitarsByVendor(string vendor);

        IEnumerable<AcousticClassicalGuitarViewModel> GetAcousticClassicalGuitarsByVendor(string vendor);

        IEnumerable<AcousticWesternGuitarViewModel> GetAcousticWesternGuitarsByVendor(string vendor);

        IEnumerable<ElectricGuitarViewModel> GetElectricGuitarsByVendor(string vendor);

        IEnumerable<BassGuitarViewModel> GetBassGuitarsByVendor(string vendor);
    }
}