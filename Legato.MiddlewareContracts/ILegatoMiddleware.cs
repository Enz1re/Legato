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
        IEnumerable<GuitarDataModel> GetGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<ElectroGuitarDataModel> GetElectroGuitarsByPrice(short from, short to);

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars();

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars();

        [OperationContract]
        IEnumerable<ElectroGuitarDataModel> GetAllElectroGuitars();

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetAllBassGuitars();

        [OperationContract]
        IEnumerable<GuitarDataModel> GetGuitarsByVendor(string vendor);

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendor(string vendor);

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendor(string vendor);

        [OperationContract]
        IEnumerable<ElectroGuitarDataModel> GetElectroGuitarsByVendor(string vendor);

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendor(string vendor);
    }
}
