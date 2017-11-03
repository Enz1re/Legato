using Legato.Service.ReturnTypes;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service
{
    public interface ILegatoServiceWorker
    {
        GuitarList GetAcousticClassicalGuitars(FilterViewModel filter, int lowerBound, int upperBound);

        VendorList GetAcousticClassicalGuitarVendors();

        Amount GetAcousticClassicalGuitarAmount();

        GuitarList GetAcousticWesternGuitars(FilterViewModel filter, int lowerBound, int upperBound);

        VendorList GetAcousticWesternGuitarVendors();

        Amount GetAcousticWesternGuitarAmount();

        GuitarList GetElectricGuitars(FilterViewModel filter, int lowerBound, int upperBound);

        VendorList GetElectricGuitarVendors();

        Amount GetElectricGuitarAmount();

        GuitarList GetBassGuitars(FilterViewModel filter, int lowerBound, int upperBound);

        VendorList GetBassGuitarVendors();

        Amount GetBassGuitarAmount();
    }
}