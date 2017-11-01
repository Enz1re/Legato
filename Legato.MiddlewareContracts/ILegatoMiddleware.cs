using System.ServiceModel;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.MiddlewareContracts
{
    [ServiceContract]
    public interface ILegatoMiddleware
    {
        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars(int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<string> GetAcousticClassicalGuitarVendors();

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(int from, int to, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendors(string[] vendors, int lowerBound, int upperBound);

        [OperationContract]
        int GetAcousticClassicalGuitarQuantity();

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars(int lowerBound, int upperBound);


        [OperationContract]
        IEnumerable<string> GetAcousticWesternGuitarVendors();

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(int from, int to, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendors(string[] vendors, int lowerBound, int upperBound);

        [OperationContract]
        int GetAcousticWesternGuitarQuantity();

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetAllElectricGuitars(int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<string> GetElectricGuitarVendors();

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByPrice(int from, int to, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByVendors(string[] vendors, int lowerBound, int upperBound);

        [OperationContract]
        int GetElectricGuitarQuantity();

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetAllBassGuitars(int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<string> GetBassGuitarVendors();

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(int from, int to, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendors(string[] vendors, int lowerBound, int upperBound);

        [OperationContract]
        int GetBassGuitarQuantity();
    }
}
