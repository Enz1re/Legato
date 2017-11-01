using Legato.Service.ReturnTypes;


namespace Legato.Service
{
    public interface ILegatoServiceWorker
    {
        VendorList GetAcousticClassicalGuitarVendors();

        GuitarList GetAcousticClassicalGuitarsByPrice(short from, short to);

        VendorList GetAcousticWesternGuitarVendors();

        GuitarList GetAcousticWesternGuitarsByPrice(short from, short to);

        GuitarList GetBassGuitarsByPrice(short from, short to);

        VendorList GetElectricGuitarVendors();

        GuitarList GetElectricGuitarsByPrice(short from, short to);

        GuitarList GetAllAcousticClassicalGuitars();

        GuitarList GetAllAcousticWesternGuitars();

        GuitarList GetAllElectricGuitars();

        VendorList GetBassGuitarVendors();

        GuitarList GetAllBassGuitars();

        GuitarList GetAcousticClassicalGuitarsByVendor(string vendor);

        GuitarList GetAcousticWesternGuitarsByVendor(string vendor);

        GuitarList GetElectricGuitarsByVendor(string vendor);

        GuitarList GetBassGuitarsByVendor(string vendor);
    }
}