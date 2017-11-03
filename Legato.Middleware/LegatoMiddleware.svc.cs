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

        public IEnumerable<string> GetAcousticClassicalGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticClassicalGuitarVendors();
            }
        }

        public int GetAcousticClassicalGuitarQuantity()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticClassicalGuitarAmount();
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticWesternGuitars(filter, lowerBound, upperBound);
            }
        }

        public IEnumerable<string> GetAcousticWesternGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticWesternGuitarVendors();
            }
        }

        public int GetAcousticWesternGuitarQuantity()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticWesternGuitarAmount();
            }
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectricGuitars(filter, lowerBound, upperBound);
            }
        }

        public IEnumerable<string> GetElectricGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectricGuitarVendors();
            }
        }

        public int GetElectricGuitarQuantity()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectriGuitarAmount();
            }
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetBassGuitars(filter, lowerBound, upperBound);
            }
        }

        public IEnumerable<string> GetBassGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetBassGuitarVendors();
            }
        }

        public int GetBassGuitarQuantity()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetBassGuitarAmount();
            }
        }
    }
}
