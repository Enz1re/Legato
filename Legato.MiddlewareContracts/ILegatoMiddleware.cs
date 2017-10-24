using System.ServiceModel;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.MiddlewareContracts
{
    [ServiceContract]
    public interface ILegatoMiddleware
    {
        [OperationContract]
        IEnumerable<GuitarDataModel> GetAllGuitars();

        [OperationContract]
        IEnumerable<string> GetAllVendors();

        [OperationContract]
        IEnumerable<GuitarDataModel> GetGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<GuitarDataModel> GetGuitarsByVendor(string vendor);

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars();

        [OperationContract]
        IEnumerable<string> GetAcousticClassicalGuitarVendors();

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendor(string vendor);

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars();

        [OperationContract]
        IEnumerable<string> GetAcousticWesternGuitarVendors();

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendor(string vendor);

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetAllElectricGuitars();

        [OperationContract]
        IEnumerable<string> GetElectricGuitarVendors();

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByVendor(string vendor);

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetAllBassGuitars();

        [OperationContract]
        IEnumerable<string> GetBassGuitarVendors();

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendor(string vendor);
    }
}
