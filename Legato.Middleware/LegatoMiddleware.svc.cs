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

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars(int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllAcousticClassicalGuitars(lowerBound, upperBound);
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

        public IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars(int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllAcousticWesternGuitars(lowerBound, upperBound);
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

        public IEnumerable<BassGuitarDataModel> GetAllBassGuitars(int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllBassGuitars(lowerBound, upperBound);
            }
        }

        public IEnumerable<string> GetElectricGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectricGuitarVendors();
            }
        }

        public IEnumerable<ElectricGuitarDataModel> GetAllElectricGuitars(int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllElectricGuitars(lowerBound, upperBound);
            }
        }

        public int GetElectricGuitarQuantity()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectriGuitarAmount();
            }
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(int from, int to, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticClassicalGuitarsByPrice(from, to, lowerBound, upperBound);
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

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(int from, int to, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticWesternGuitarsByPrice(from, to, lowerBound, upperBound);
            }
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByPrice(int from, int to, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectricGuitarsByPrice(from, to, lowerBound, upperBound);
            }
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(int from, int to, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetBassGuitarsByPrice(from, to, lowerBound, upperBound);
            }
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticClassicalGuitarsByVendors(vendors, lowerBound, upperBound);
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticWesternGuitarsByVendors(vendors, lowerBound, upperBound);
            }
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectricGuitarsByVendors(vendors, lowerBound, upperBound);
            }
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetBassGuitarsByVendors(vendors, lowerBound, upperBound);
            }
        }
    }
}
