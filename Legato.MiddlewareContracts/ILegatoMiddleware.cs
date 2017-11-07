using System.ServiceModel;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.MiddlewareContracts
{
    [ServiceContract]
    public interface ILegatoMiddleware
    {
        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<string> GetAcousticClassicalGuitarVendors();

        [OperationContract]
        int GetAcousticClassicalGuitarQuantity(FilterDataModel filter);

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetSortedAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting);

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<string> GetAcousticWesternGuitarVendors();

        [OperationContract]
        int GetAcousticWesternGuitarQuantity(FilterDataModel filter);

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetSortedAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting);

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<string> GetElectricGuitarVendors();

        [OperationContract]
        int GetElectricGuitarQuantity(FilterDataModel filter);

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetSortedElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting);

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<string> GetBassGuitarVendors();

        [OperationContract]
        int GetBassGuitarQuantity(FilterDataModel filter);

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetSortedBassGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting);
    }
}
