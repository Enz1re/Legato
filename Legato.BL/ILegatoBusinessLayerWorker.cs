using System;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL
{
    public interface ILegatoBusinessLayerWorker : IDisposable
    {
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<string> GetAcousticClassicalGuitarVendors();

        int GetAcousticClassicalGuitarAmount(FilterDataModel filter);

        IEnumerable<AcousticClassicalGuitarDataModel> GetSortedAcousticClassicalGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<AcousticClassicalGuitarDataModel> GetSortedAcousticClassicalGuitarsByVendor(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<string> GetAcousticWesternGuitarVendors();

        int GetAcousticWesternGuitarAmount(FilterDataModel filter);

        IEnumerable<AcousticWesternGuitarDataModel> GetSortedAcousticWesternGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<AcousticWesternGuitarDataModel> GetSortedAcousticWesternGuitarsByVendor(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<string> GetElectricGuitarVendors();

        int GetElectriGuitarAmount(FilterDataModel filter);

        IEnumerable<ElectricGuitarDataModel> GetSortedElectricGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<ElectricGuitarDataModel> GetSortedElectricGuitarsByVendor(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        IEnumerable<string> GetBassGuitarVendors();

        int GetBassGuitarAmount(FilterDataModel filter);

        IEnumerable<BassGuitarDataModel> GetSortedBassGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        IEnumerable<BassGuitarDataModel> GetSortedBassGuitarsByVendor(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection);

        ILegatoBusinessLayerWorker Get();
    }
}
