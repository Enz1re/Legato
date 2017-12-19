using Legato.Service.ReturnTypes;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Interfaces
{
    public interface ILegatoGuitarServiceWorker
    {
        GuitarList GetAcousticClassicalGuitars(FilterViewModel filter, int lowerBound, int upperBound);

        GuitarList GetSortedAcousticClassicalGuitars(FilterViewModel filter, int lowerBound, int upperBound, SortingViewModel sorting);

        VendorList GetAcousticClassicalGuitarVendors();

        Amount GetAcousticClassicalGuitarAmount(FilterViewModel filter);
        
        GuitarList GetAcousticWesternGuitars(FilterViewModel filter, int lowerBound, int upperBound);

        GuitarList GetSortedAcousticWesternGuitars(FilterViewModel filter, int lowerBound, int upperBound, SortingViewModel sorting);

        VendorList GetAcousticWesternGuitarVendors();

        Amount GetAcousticWesternGuitarAmount(FilterViewModel filter);

        GuitarList GetElectricGuitars(FilterViewModel filter, int lowerBound, int upperBound);

        GuitarList GetSortedElectricGuitars(FilterViewModel filter, int lowerBound, int upperBound, SortingViewModel sorting);

        VendorList GetElectricGuitarVendors();

        Amount GetElectricGuitarAmount(FilterViewModel filter);

        GuitarList GetBassGuitars(FilterViewModel filter, int lowerBound, int upperBound);

        GuitarList GetSortedBassGuitars(FilterViewModel filter, int lowerBound, int upperBound, SortingViewModel sorting);

        VendorList GetBassGuitarVendors();

        Amount GetBassGuitarAmount(FilterViewModel filter);
    }
}