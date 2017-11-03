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
        int GetAcousticClassicalGuitarQuantity();

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<string> GetAcousticWesternGuitarVendors();

        [OperationContract]
        int GetAcousticWesternGuitarQuantity();

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<string> GetElectricGuitarVendors();

        [OperationContract]
        int GetElectricGuitarQuantity();

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<string> GetBassGuitarVendors();

        [OperationContract]
        int GetBassGuitarQuantity();
    }
}
