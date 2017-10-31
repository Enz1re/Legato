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

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllAcousticClassicalGuitars();
            }
        }

        public IEnumerable<VendorDataModel> GetAcousticClassicalGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticClassicalGuitarVendors();
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllAcousticWesternGuitars();
            }
        }

        public IEnumerable<VendorDataModel> GetAcousticWesternGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticWesternGuitarVendors();
            }
        }

        public IEnumerable<BassGuitarDataModel> GetAllBassGuitars()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllBassGuitars();
            }
        }

        public IEnumerable<VendorDataModel> GetElectricGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectricGuitarVendors();
            }
        }

        public IEnumerable<ElectricGuitarDataModel> GetAllElectricGuitars()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllElectricGuitars();
            }
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(short from, short to)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticClassicalGuitarsByPrice(from, to);
            }
        }

        public IEnumerable<VendorDataModel> GetBassGuitarVendors()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetBassGuitarVendors();
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(short from, short to)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticWesternGuitarsByPrice(from, to);
            }
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByPrice(short from, short to)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectricGuitarsByPrice(from, to);
            }
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(short from, short to)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetBassGuitarsByPrice(from, to);
            }
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendor(string vendor)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticClassicalGuitarsByVendor(vendor);
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendor(string vendor)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticWesternGuitarsByVendor(vendor);
            }
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByVendor(string vendor)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectricGuitarsByVendor(vendor);
            }
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendor(string vendor)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetBassGuitarsByVendor(vendor);
            }
        }
    }
}
