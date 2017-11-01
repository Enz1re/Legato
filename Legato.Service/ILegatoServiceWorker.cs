using Legato.Service.ReturnTypes;


namespace Legato.Service
{
    public interface ILegatoServiceWorker
    {
        GuitarList GetAllAcousticClassicalGuitars(int lowerBound, int upperBound);

        VendorList GetAcousticClassicalGuitarVendors();

        GuitarList GetAcousticClassicalGuitarsByPrice(int from, int to, int lowerBound, int upperBound);

        GuitarList GetAcousticClassicalGuitarsByVendors(string[] vendors, int lowerBound, int upperBound);

        Amount GetAcousticClassicalGuitarAmount();

        GuitarList GetAllAcousticWesternGuitars(int lowerBound, int upperBound);

        VendorList GetAcousticWesternGuitarVendors();

        GuitarList GetAcousticWesternGuitarsByPrice(int from, int to, int lowerBound, int upperBound);

        GuitarList GetAcousticWesternGuitarsByVendors(string[] vendors, int lowerBound, int upperBound);

        Amount GetAcousticWesternGuitarAmount();

        GuitarList GetAllElectricGuitars(int lowerBound, int upperBound);

        VendorList GetElectricGuitarVendors();

        GuitarList GetElectricGuitarsByPrice(int from, int to, int lowerBound, int upperBound);

        GuitarList GetElectricGuitarsByVendors(string[] vendors, int lowerBound, int upperBound);

        Amount GetElectricGuitarAmount();

        GuitarList GetAllBassGuitars(int lowerBound, int upperBound);

        VendorList GetBassGuitarVendors();

        GuitarList GetBassGuitarsByPrice(int from, int to, int lowerBound, int upperBound);

        GuitarList GetBassGuitarsByVendors(string[] vendors, int lowerBound, int upperBound);

        Amount GetBassGuitarAmount();
    }
}