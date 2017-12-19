using System.ServiceModel;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.MiddlewareContracts
{
    [ServiceContract]
    public interface ILegatoMiddleware
    {
        #region Classical

        [OperationContract]
        void AddAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar);

        [OperationContract]
        void EditAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar);

        [OperationContract]
        void RemoveAcousticClassicalGuitar(int id);

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<AcousticClassicalGuitarDataModel> GetSortedAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting);

        [OperationContract]
        IEnumerable<VendorDataModel> GetAcousticClassicalGuitarVendors();

        [OperationContract]
        int GetAcousticClassicalGuitarQuantity(FilterDataModel filter);

        #endregion

        #region Western

        [OperationContract]
        void AddAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar);

        [OperationContract]
        void EditAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar);

        [OperationContract]
        void RemoveAcousticWesternGuitar(int id);

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<AcousticWesternGuitarDataModel> GetSortedAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting);

        [OperationContract]
        IEnumerable<VendorDataModel> GetAcousticWesternGuitarVendors();

        [OperationContract]
        int GetAcousticWesternGuitarQuantity(FilterDataModel filter);

        #endregion

        #region Electric

        [OperationContract]
        void AddElectricGuitar(ElectricGuitarDataModel guitar);

        [OperationContract]
        void EditElectricGuitar(ElectricGuitarDataModel guitar);

        [OperationContract]
        void RemoveElectricGuitar(int id);

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<ElectricGuitarDataModel> GetSortedElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting);

        [OperationContract]
        IEnumerable<VendorDataModel> GetElectricGuitarVendors();

        [OperationContract]
        int GetElectricGuitarQuantity(FilterDataModel filter);

        #endregion

        #region Bass

        [OperationContract]
        void AddBassGuitar(BassGuitarDataModel guitar);

        [OperationContract]
        void EditBassGuitar(BassGuitarDataModel guitar);

        [OperationContract]
        void RemoveBassGuitar(int id);

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound);

        [OperationContract]
        IEnumerable<BassGuitarDataModel> GetSortedBassGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting);

        [OperationContract]
        IEnumerable<VendorDataModel> GetBassGuitarVendors();

        [OperationContract]
        int GetBassGuitarQuantity(FilterDataModel filter);

        #endregion

        #region User

        [OperationContract]
        bool FindUser(string username, string password);

        [OperationContract]
        void AddTokenToStorage(string accessToken, int expireMinutes);

        [OperationContract]
        void RemoveTokenFromStorage(string token);

        [OperationContract]
        void BanToken(string token);

        [OperationContract]
        bool IsTokenValid(string token);

        [OperationContract]
        bool IsTokenBanned(string token);

        [OperationContract]
        IEnumerable<string> GetUserClaims(string username);

        [OperationContract]
        void AddClaim(string username, string userClaim);

        #endregion
    }
}
