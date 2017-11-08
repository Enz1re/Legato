using System;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL
{
    public interface ILegatoBusinessLayerWorker : IDisposable
    {
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<AcousticClassicalGuitarDataModel> GetSortedAcousticClassicalGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<AcousticClassicalGuitarDataModel> GetSortedAcousticClassicalGuitarsByVendor(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<string> GetAcousticClassicalGuitarVendors();

        int GetAcousticClassicalGuitarAmount(FilterDataModel filter);

        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<AcousticWesternGuitarDataModel> GetSortedAcousticWesternGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<AcousticWesternGuitarDataModel> GetSortedAcousticWesternGuitarsByVendor(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<string> GetAcousticWesternGuitarVendors();

        int GetAcousticWesternGuitarAmount(FilterDataModel filter);

        IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<ElectricGuitarDataModel> GetSortedElectricGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<ElectricGuitarDataModel> GetSortedElectricGuitarsByVendor(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<string> GetElectricGuitarVendors();

        int GetElectriGuitarAmount(FilterDataModel filter);

        IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<BassGuitarDataModel> GetSortedBassGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<BassGuitarDataModel> GetSortedBassGuitarsByVendor(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<string> GetBassGuitarVendors();

        int GetBassGuitarAmount(FilterDataModel filter);

        ILegatoBusinessLayerWorker Get();
    }
}
