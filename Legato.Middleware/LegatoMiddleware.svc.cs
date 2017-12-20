using Ninject;
using System.Linq;
using Legato.BL.Interfaces;
using System.Collections.Generic;
using Legato.MiddlewareContracts;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.Middleware
{
    public class LegatoMiddleware : ILegatoMiddleware
    {
        private ILegatoGuitarBLWorker _blGuitarWorker;
        private ILegatoManageBLWorker _blManageWorker;
        private ILegatoUserBLWorker _blUserWorker;
        private static object _locker = new object();
        
        [Inject]
        public LegatoMiddleware(ILegatoGuitarBLWorker guitarWorker, ILegatoManageBLWorker manageWorker, ILegatoUserBLWorker userWorker)
        {
            _blGuitarWorker = guitarWorker;
            _blManageWorker = manageWorker;
            _blUserWorker = userWorker;
        }

        #region Classical

        public void AddAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar)
        {
            _blManageWorker.AddAcousticClassicalGuitar(guitar);
        }

        public void EditAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar)
        {
            _blManageWorker.EditAcousticClassicalGuitar(guitar);
        }

        public void RemoveAcousticClassicalGuitar(int id)
        {
            _blManageWorker.RemoveAcousticClassicalGuitar(id);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            return _blGuitarWorker.GetAcousticClassicalGuitars(filter, lowerBound, upperBound);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetSortedAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            if (sorting.SortHeader == SortHeader.Price)
                return _blGuitarWorker.GetSortedAcousticClassicalGuitarsByPrice(filter, lowerBound, upperBound, sorting.SortDirection);
            else
                return _blGuitarWorker.GetSortedAcousticClassicalGuitarsByVendor(filter, lowerBound, upperBound, sorting.SortDirection);
        }

        public IEnumerable<VendorDataModel> GetAcousticClassicalGuitarVendors()
        {
            return _blGuitarWorker.GetAcousticClassicalGuitarVendors().Distinct(new VendorEqualityComparer());
        }

        public int GetAcousticClassicalGuitarQuantity(FilterDataModel filter)
        {
            return _blGuitarWorker.GetAcousticClassicalGuitarAmount(filter);
        }

        #endregion

        #region Western

        public void AddAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar)
        {
            _blManageWorker.AddAcousticWesternGuitar(guitar);
        }

        public void EditAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar)
        {
            _blManageWorker.EditAcousticWesternGuitar(guitar);
        }

        public void RemoveAcousticWesternGuitar(int id)
        {
            _blManageWorker.RemoveAcousticWesternGuitar(id);
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            return _blGuitarWorker.GetAcousticWesternGuitars(filter, lowerBound, upperBound);
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetSortedAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            if (sorting.SortHeader == SortHeader.Price)
                return _blGuitarWorker.GetSortedAcousticWesternGuitarsByPrice(filter, lowerBound, upperBound, sorting.SortDirection);
            else
                return _blGuitarWorker.GetSortedAcousticWesternGuitarsByVendor(filter, lowerBound, upperBound, sorting.SortDirection);
        }

        public IEnumerable<VendorDataModel> GetAcousticWesternGuitarVendors()
        {
            return _blGuitarWorker.GetAcousticWesternGuitarVendors().Distinct(new VendorEqualityComparer());
        }

        public int GetAcousticWesternGuitarQuantity(FilterDataModel filter)
        {
            return _blGuitarWorker.GetAcousticWesternGuitarAmount(filter);
        }

        #endregion

        #region Electric

        public void AddElectricGuitar(ElectricGuitarDataModel guitar)
        {
            _blManageWorker.AddElectricGuitar(guitar);
        }

        public void EditElectricGuitar(ElectricGuitarDataModel guitar)
        {
            _blManageWorker.EditElectricGuitar(guitar);
        }

        public void RemoveElectricGuitar(int id)
        {
            _blManageWorker.RemoveElectricGuitar(id);
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            return _blGuitarWorker.GetElectricGuitars(filter, lowerBound, upperBound);
        }

        public IEnumerable<ElectricGuitarDataModel> GetSortedElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            if (sorting.SortHeader == SortHeader.Price)
                return _blGuitarWorker.GetSortedElectricGuitarsByPrice(filter, lowerBound, upperBound, sorting.SortDirection);
            else
                return _blGuitarWorker.GetSortedElectricGuitarsByVendor(filter, lowerBound, upperBound, sorting.SortDirection);
        }

        public IEnumerable<VendorDataModel> GetElectricGuitarVendors()
        {
            return _blGuitarWorker.GetElectricGuitarVendors().Distinct(new VendorEqualityComparer());
        }

        public int GetElectricGuitarQuantity(FilterDataModel filter)
        {
            return _blGuitarWorker.GetElectriGuitarAmount(filter);
        }

        #endregion

        #region Bass

        public void AddBassGuitar(BassGuitarDataModel guitar)
        {
            _blManageWorker.AddBassGuitar(guitar);
        }

        public void EditBassGuitar(BassGuitarDataModel guitar)
        {
            _blManageWorker.EditBassGuitar(guitar);
        }

        public void RemoveBassGuitar(int id)
        {
            _blManageWorker.RemoveBassGuitar(id);
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            return _blGuitarWorker.GetBassGuitars(filter, lowerBound, upperBound);
        }

        public IEnumerable<BassGuitarDataModel> GetSortedBassGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            if (sorting.SortHeader == SortHeader.Price)
                return _blGuitarWorker.GetSortedBassGuitarsByPrice(filter, lowerBound, upperBound, sorting.SortDirection);
            else
                return _blGuitarWorker.GetSortedBassGuitarsByVendor(filter, lowerBound, upperBound, sorting.SortDirection);
        }

        public IEnumerable<VendorDataModel> GetBassGuitarVendors()
        {
            return _blGuitarWorker.GetBassGuitarVendors().Distinct(new VendorEqualityComparer());
        }

        public int GetBassGuitarQuantity(FilterDataModel filter)
        {
            return _blGuitarWorker.GetBassGuitarAmount(filter);
        }

        #endregion

        #region User

        public bool FindUserByUsername(string username)
        {
            return _blUserWorker.FindUser(username);
        }

        public bool FindUser(string username, string password)
        {
            return _blUserWorker.FindUser(username, password);
        }

        public void AddTokenToStorage(string accessToken, int expireMinutes)
        {
            _blUserWorker.AddToken(accessToken, expireMinutes);
        }

        public void RemoveTokenFromStorage(string token)
        {
            _blUserWorker.RemoveToken(token);
        }

        public void BanToken(string token)
        {
            _blUserWorker.BanToken(token);
        }

        public bool IsTokenValid(string token)
        {
            return _blUserWorker.IsTokenValid(token);
        }

        public bool IsTokenBanned(string token)
        {
            return _blUserWorker.IsTokenBanned(token);
        }

        public void RemoveExpiredTokens()
        {
            lock (_locker)
            {
                _blUserWorker.RemoveExpiredTokens();
            }
        }

        public IEnumerable<string> GetUserClaims(string username)
        {
            return _blUserWorker.GetUserClaims(username);
        }

        public void AddClaim(string username, string userClaim)
        {
            _blUserWorker.AddClaim(username, userClaim);
        }

        #endregion
    }
}
