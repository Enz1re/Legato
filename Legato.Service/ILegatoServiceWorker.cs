using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service
{
    public interface ILegatoServiceWorker
    {
        IEnumerable<GuitarViewModel> GetAllGuitars();

        IEnumerable<GuitarViewModel> GetGuitarsByPrice(short from, short to);

        IEnumerable<AcousticClassicalGuitarViewModel> GetAcousticClassicalGuitarsByPrice(short from, short to);

        IEnumerable<AcousticWesternGuitarViewModel> GetAcousticWesternGuitarsByPrice(short from, short to);

        IEnumerable<BassGuitarViewModel> GetBassGuitarsByPrice(short from, short to);

        IEnumerable<ElectroGuitarViewModel> GetElectroGuitarsByPrice(short from, short to);

        IEnumerable<AcousticClassicalGuitarViewModel> GetAllAcousticClassicalGuitars();

        IEnumerable<AcousticWesternGuitarViewModel> GetAllAcousticWesternGuitars();

        IEnumerable<ElectroGuitarViewModel> GetAllElectroGuitars();

        IEnumerable<BassGuitarViewModel> GetAllBassGuitars();

        IEnumerable<GuitarViewModel> GetGuitarsByVendor(string vendor);

        IEnumerable<AcousticClassicalGuitarViewModel> GetAcousticClassicalGuitarsByVendor(string vendor);

        IEnumerable<AcousticWesternGuitarViewModel> GetAcousticWesternGuitarsByVendor(string vendor);

        IEnumerable<ElectroGuitarViewModel> GetElectroGuitarsByVendor(string vendor);

        IEnumerable<BassGuitarViewModel> GetBassGuitarsByVendor(string vendor);
    }
}