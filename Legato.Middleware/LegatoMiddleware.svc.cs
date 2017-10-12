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

        public IEnumerable<GuitarDataModel> GetAllGuitars()
        {
            using (_blWorker)
            {
                return _blWorker.GetAllGuitars();
            }
        }

        public IEnumerable<GuitarDataModel> GetGuitarsByPrice(short from, short to)
        {
            using (_blWorker)
            {
                return _blWorker.GetGuitarsByPrice(from, to);
            }
        }

        public IEnumerable<GuitarDataModel> GetGuitarsByVendor(string vendor)
        {
            using (_blWorker)
            {
                return _blWorker.GetGuitarsByVendor(vendor);
            }
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars()
        {
            using (_blWorker)
            {
                return _blWorker.GetAllAcousticClassicalGuitars();
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars()
        {
            using (_blWorker)
            {
                return _blWorker.GetAllAcousticWesternGuitars();
            }
        }

        public IEnumerable<BassGuitarDataModel> GetAllBassGuitars()
        {
            using (_blWorker)
            {
                return _blWorker.GetAllBassGuitars();
            }
        }

        public IEnumerable<ElectroGuitarDataModel> GetAllElectroGuitars()
        {
            using (_blWorker)
            {
                return _blWorker.GetAllElectroGuitars();
            }
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(short from, short to)
        {
            using (_blWorker)
            {
                return _blWorker.GetAcousticClassicalGuitarsByPrice(from, to);
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(short from, short to)
        {
            using (_blWorker)
            {
                return _blWorker.GetAcousticWesternGuitarsByPrice(from, to);
            }
        }

        public IEnumerable<ElectroGuitarDataModel> GetElectroGuitarsByPrice(short from, short to)
        {
            using (_blWorker)
            {
                return _blWorker.GetElectroGuitarsByPrice(from, to);
            }
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(short from, short to)
        {
            using (_blWorker)
            {
                return _blWorker.GetBassGuitarsByPrice(from, to);
            }
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendor(string vendor)
        {
            using (_blWorker)
            {
                return _blWorker.GetAcousticClassicalGuitarsByVendor(vendor);
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendor(string vendor)
        {
            using (_blWorker)
            {
                return _blWorker.GetAcousticWesternGuitarsByVendor(vendor);
            }
        }

        public IEnumerable<ElectroGuitarDataModel> GetElectroGuitarsByVendor(string vendor)
        {
            using (_blWorker)
            {
                return _blWorker.GetElectroGuitarsByVendor(vendor);
            }
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendor(string vendor)
        {
            using (_blWorker)
            {
                return _blWorker.GetBassGuitarsByVendor(vendor);
            }
        }
    }
}
