﻿using Ninject;
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
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllGuitars();
            }
        }

        public IEnumerable<GuitarDataModel> GetGuitarsByPrice(short from, short to)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetGuitarsByPrice(from, to);
            }
        }

        public IEnumerable<GuitarDataModel> GetGuitarsByVendor(string vendor)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetGuitarsByVendor(vendor);
            }
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllAcousticClassicalGuitars();
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllAcousticWesternGuitars();
            }
        }

        public IEnumerable<BassGuitarDataModel> GetAllBassGuitars()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllBassGuitars();
            }
        }

        public IEnumerable<ElectroGuitarDataModel> GetAllElectroGuitars()
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAllElectroGuitars();
            }
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(short from, short to)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticClassicalGuitarsByPrice(from, to);
            }
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(short from, short to)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetAcousticWesternGuitarsByPrice(from, to);
            }
        }

        public IEnumerable<ElectroGuitarDataModel> GetElectroGuitarsByPrice(short from, short to)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectroGuitarsByPrice(from, to);
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

        public IEnumerable<ElectroGuitarDataModel> GetElectroGuitarsByVendor(string vendor)
        {
            using (var worker = _blWorker.Get())
            {
                return worker.GetElectroGuitarsByVendor(vendor);
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
