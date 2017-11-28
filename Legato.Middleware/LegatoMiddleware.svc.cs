using Ninject;
using Legato.BL;
using System.Collections.Generic;
using Legato.MiddlewareContracts;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.Middleware
{
    public class LegatoMiddleware : ILegatoMiddleware
    {
        private ILegatoBusinessLayerWorker _blWorker;

        [Inject]
        public LegatoMiddleware(ILegatoBusinessLayerWorker blWorker)
        {
            _blWorker = blWorker;
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticClassicalGuitars(filter, lowerBound, upperBound);
            }
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetSortedAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            using (var worker = _blWorker.Get())
            {
                if (sorting.SortHeader == SortHeader.Price)
                    return worker.GetSortedAcousticClassicalGuitarsByPrice(filter, lowerBound, upperBound, sorting.SortDirection);
                else
                    return worker.GetSortedAcousticClassicalGuitarsByVendor(filter, lowerBound, upperBound, sorting.SortDirection);
            }
        }
        
        public IEnumerable<string> GetAcousticClassicalGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticClassicalGuitarVendors();
            }
        }

        public int GetAcousticClassicalGuitarQuantity(FilterDataModel filter)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticClassicalGuitarAmount(filter);
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticWesternGuitars(filter, lowerBound, upperBound);
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetSortedAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            using (var worker = _blWorker.Get())
            {
                if (sorting.SortHeader == SortHeader.Price)
                    return worker.GetSortedAcousticWesternGuitarsByPrice(filter, lowerBound, upperBound, sorting.SortDirection);
                else
                    return worker.GetSortedAcousticWesternGuitarsByVendor(filter, lowerBound, upperBound, sorting.SortDirection);
            }
        }
        
        public IEnumerable<string> GetAcousticWesternGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticWesternGuitarVendors();
            }
        }

        public int GetAcousticWesternGuitarQuantity(FilterDataModel filter)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticWesternGuitarAmount(filter);
            }
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectricGuitars(filter, lowerBound, upperBound);
            }
        }

        public IEnumerable<ElectricGuitarDataModel> GetSortedElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            using (var worker = _blWorker.Get())
            {
                if (sorting.SortHeader == SortHeader.Price)
                    return worker.GetSortedElectricGuitarsByPrice(filter, lowerBound, upperBound, sorting.SortDirection);
                else
                    return worker.GetSortedElectricGuitarsByVendor(filter, lowerBound, upperBound, sorting.SortDirection);
            }
        }
        
        public IEnumerable<string> GetElectricGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectricGuitarVendors();
            }
        }

        public int GetElectricGuitarQuantity(FilterDataModel filter)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectriGuitarAmount(filter);
            }
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetBassGuitars(filter, lowerBound, upperBound);
            }
        }

        public IEnumerable<BassGuitarDataModel> GetSortedBassGuitars(FilterDataModel filter, int lowerBound, int upperBound, SortingDataModel sorting)
        {
            using (var worker = _blWorker.Get())
            {
                if (sorting.SortHeader == SortHeader.Price)
                    return worker.GetSortedBassGuitarsByPrice(filter, lowerBound, upperBound, sorting.SortDirection);
                else
                    return worker.GetSortedBassGuitarsByVendor(filter, lowerBound, upperBound, sorting.SortDirection);
            }
        }
        
        public IEnumerable<string> GetBassGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetBassGuitarVendors();
            }
        }

        public int GetBassGuitarQuantity(FilterDataModel filter)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetBassGuitarAmount(filter);
            }
        }
    }
}
