using Ninject;
using Legato.BL;
using System.Collections.Generic;
using Legato.MiddlewareContracts;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.Middleware
{
    public class LegatoMiddleware : ILegatoMiddleware
    {
        private ILegatoGuitarBLWorker _blGuitarWorker;
        private ILegatoManageBLWorker _blManageWorker;

        [Inject]
        public LegatoMiddleware(ILegatoGuitarBLWorker guitarWorker, ILegatoManageBLWorker manageWorker)
        {
            _blGuitarWorker = guitarWorker;
            _blManageWorker = manageWorker;
        }

        #region Classical

        public void AddAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar)
        {
            using (var worker = _blManageWorker.Get())
            {
                worker.AddAcousticClassicalGuitar(guitar);
            }
        }

        public void EditAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar)
        {
            using (var worker = _blManageWorker.Get())
            {
                worker.EditAcousticClassicalGuitar(guitar);
            }
        }

        public void RemoveAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar)
        {
            using (var worker = _blManageWorker.Get())
            {
                worker.RemoveAcousticClassicalGuitar(guitar);
            }
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            using (var worker = _blGuitarWorker.Get())
            {
                return worker.GetAcousticClassicalGuitars(filter, lowerBound, upperBound);
            }
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetSortedAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            using (var worker = _blGuitarWorker.Get())
            {
                if (sorting.SortHeader == SortHeader.Price)
                    return worker.GetSortedAcousticClassicalGuitarsByPrice(filter, lowerBound, upperBound, sorting.SortDirection);
                else
                    return worker.GetSortedAcousticClassicalGuitarsByVendor(filter, lowerBound, upperBound, sorting.SortDirection);
            }
        }
        
        public IEnumerable<string> GetAcousticClassicalGuitarVendors()
        {
            using (var worker = _blGuitarWorker.Get())
            {
                return worker.GetAcousticClassicalGuitarVendors();
            }
        }

        public int GetAcousticClassicalGuitarQuantity(FilterDataModel filter)
        {
            using (var worker = _blGuitarWorker.Get())
            {
                return worker.GetAcousticClassicalGuitarAmount(filter);
            }
        }

        #endregion

        #region Western

        public void AddAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar)
        {
            using (var worker = _blManageWorker.Get())
            {
                worker.AddAcousticWesternGuitar(guitar);
            }
        }

        public void EditAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar)
        {
            using (var worker = _blManageWorker.Get())
            {
                worker.EditAcousticWesternGuitar(guitar);
            }
        }

        public void RemoveAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar)
        {
            using (var worker = _blManageWorker.Get())
            {
                worker.RemoveAcousticWesternGuitar(guitar);
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            using (var worker = _blGuitarWorker.Get())
            {
                return worker.GetAcousticWesternGuitars(filter, lowerBound, upperBound);
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetSortedAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            using (var worker = _blGuitarWorker.Get())
            {
                if (sorting.SortHeader == SortHeader.Price)
                    return worker.GetSortedAcousticWesternGuitarsByPrice(filter, lowerBound, upperBound, sorting.SortDirection);
                else
                    return worker.GetSortedAcousticWesternGuitarsByVendor(filter, lowerBound, upperBound, sorting.SortDirection);
            }
        }
        
        public IEnumerable<string> GetAcousticWesternGuitarVendors()
        {
            using (var worker = _blGuitarWorker.Get())
            {
                return worker.GetAcousticWesternGuitarVendors();
            }
        }

        public int GetAcousticWesternGuitarQuantity(FilterDataModel filter)
        {
            using (var worker = _blGuitarWorker.Get())
            {
                return worker.GetAcousticWesternGuitarAmount(filter);
            }
        }

        #endregion

        #region Electric

        public void AddElectricGuitar(ElectricGuitarDataModel guitar)
        {
            using (var worker = _blManageWorker.Get())
            {
                worker.AddElectricGuitar(guitar);
            }
        }

        public void EditElectricGuitar(ElectricGuitarDataModel guitar)
        {
            using (var worker = _blManageWorker.Get())
            {
                worker.EditElectricGuitar(guitar);
            }
        }

        public void RemoveElectricGuitar(ElectricGuitarDataModel guitar)
        {
            using (var worker = _blManageWorker.Get())
            {
                worker.RemoveElectricGuitar(guitar);
            }
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            using (var worker = _blGuitarWorker.Get())
            {
                return worker.GetElectricGuitars(filter, lowerBound, upperBound);
            }
        }

        public IEnumerable<ElectricGuitarDataModel> GetSortedElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            using (var worker = _blGuitarWorker.Get())
            {
                if (sorting.SortHeader == SortHeader.Price)
                    return worker.GetSortedElectricGuitarsByPrice(filter, lowerBound, upperBound, sorting.SortDirection);
                else
                    return worker.GetSortedElectricGuitarsByVendor(filter, lowerBound, upperBound, sorting.SortDirection);
            }
        }
        
        public IEnumerable<string> GetElectricGuitarVendors()
        {
            using (var worker = _blGuitarWorker.Get())
            {
                return worker.GetElectricGuitarVendors();
            }
        }

        public int GetElectricGuitarQuantity(FilterDataModel filter)
        {
            using (var worker = _blGuitarWorker.Get())
            {
                return worker.GetElectriGuitarAmount(filter);
            }
        }

        #endregion

        #region Bass

        public void AddBassGuitar(BassGuitarDataModel guitar)
        {
            using (var worker = _blManageWorker.Get())
            {
                worker.AddBassGuitar(guitar);
            }
        }

        public void EditBassGuitar(BassGuitarDataModel guitar)
        {
            using (var worker = _blManageWorker.Get())
            {
                worker.EditBassGuitar(guitar);
            }
        }

        public void RemoveBassGuitar(BassGuitarDataModel guitar)
        {
            using (var worker = _blManageWorker.Get())
            {
                worker.RemoveBassGuitar(guitar);
            }
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            using (var worker = _blGuitarWorker.Get())
            {
                return worker.GetBassGuitars(filter, lowerBound, upperBound);
            }
        }

        public IEnumerable<BassGuitarDataModel> GetSortedBassGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            using (var worker = _blGuitarWorker.Get())
            {
                if (sorting.SortHeader == SortHeader.Price)
                    return worker.GetSortedBassGuitarsByPrice(filter, lowerBound, upperBound, sorting.SortDirection);
                else
                    return worker.GetSortedBassGuitarsByVendor(filter, lowerBound, upperBound, sorting.SortDirection);
            }
        }
        
        public IEnumerable<string> GetBassGuitarVendors()
        {
            using (var worker = _blGuitarWorker.Get())
            {
                return worker.GetBassGuitarVendors();
            }
        }

        public int GetBassGuitarQuantity(FilterDataModel filter)
        {
            using (var worker = _blGuitarWorker.Get())
            {
                return worker.GetBassGuitarAmount(filter);
            }
        }

        #endregion
    }
}
