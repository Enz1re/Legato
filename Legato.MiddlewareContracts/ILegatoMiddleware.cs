using System.ServiceModel;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.MiddlewareContracts
{
    [ServiceContract]
    public interface ILegatoMiddleware
    {
        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars();

        [OperationContract]
        IEnumerable<VendorDataModel> GetAcousticClassicalGuitarVendors();

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendor(string vendor);

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars();

        [OperationContract]
        IEnumerable<VendorDataModel> GetAcousticWesternGuitarVendors();

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendor(string vendor);

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetAllElectricGuitars();

        [OperationContract]
        IEnumerable<VendorDataModel> GetElectricGuitarVendors();

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByVendor(string vendor);

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetAllBassGuitars();

        [OperationContract]
        IEnumerable<VendorDataModel> GetBassGuitarVendors();

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendor(string vendor);
    }
}
