using Ninject;
using System.Linq;
using Legato.DAL.Interfaces;
using System.Collections.Generic;
using Legato.MiddlewareContracts;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL
{
    public class LegatoBusinessLayerWorker : ILegatoBusinessLayerWorker
    {
        private IRepositoryProvider _repoProvider;

        [Inject]
        public LegatoBusinessLayerWorker(IRepositoryProvider repoProvider)
        {
            _repoProvider = repoProvider;
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.AcousticClassicalGuitarRepository.GetAll()
                              .Where(g =>
                                   filter.PriceFilter != null && filter.VendorFilter != null ?
                                       filter.PriceFilter.From <= g.Price && g.Price <= filter.PriceFilter.To
                                           && filter.VendorFilter.Vendors.Contains(g.Vendor.Name)
                                   : filter.PriceFilter.From <= g.Price && g.Price <= filter.PriceFilter.To ||
                                         filter.VendorFilter.Vendors.Contains(g.Vendor.Name)
                               )
                              .Skip(lowerBound)
                              .Take(upperBound - lowerBound)
                              .ToList();
            return MiddlewareMappings.Map<List<AcousticClassicalGuitarDataModel>>(guitars);
        }

        public IEnumerable<string> GetAcousticClassicalGuitarVendors()
        {
            return _repoProvider.AcousticClassicalGuitarRepository
                .GetAll()
                .Select(guitar => guitar.Vendor.Name)
                .Distinct()
                .ToList();
        }

        public int GetAcousticClassicalGuitarAmount()
        {
            return _repoProvider.AcousticClassicalGuitarRepository.GetItemAmount();
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.AcousticWesternGuitarRepository.GetAll()
                              .Where(g =>
                                   filter.PriceFilter != null && filter.VendorFilter != null ?
                                       filter.PriceFilter.From <= g.Price && g.Price <= filter.PriceFilter.To
                                           && filter.VendorFilter.Vendors.Contains(g.Vendor.Name)
                                   : filter.PriceFilter.From <= g.Price && g.Price <= filter.PriceFilter.To ||
                                         filter.VendorFilter.Vendors.Contains(g.Vendor.Name)
                               )
                              .Skip(lowerBound)
                              .Take(upperBound - lowerBound)
                              .ToList();
            return MiddlewareMappings.Map<List<AcousticWesternGuitarDataModel>>(guitars);
        }

        public IEnumerable<string> GetAcousticWesternGuitarVendors()
        {
            return _repoProvider.AcousticWesternGuitarRepository
                .GetAll()
                .Select(guitar => guitar.Vendor.Name)
                .Distinct()
                .ToList();
        }

        public int GetAcousticWesternGuitarAmount()
        {
            return _repoProvider.AcousticWesternGuitarRepository.GetItemAmount();
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.BassGuitarRepository.GetAll()
                                 .Where(g =>
                                   filter.PriceFilter != null && filter.VendorFilter != null ?
                                       filter.PriceFilter.From <= g.Price && g.Price <= filter.PriceFilter.To
                                           && filter.VendorFilter.Vendors.Contains(g.Vendor.Name)
                                   : filter.PriceFilter.From <= g.Price && g.Price <= filter.PriceFilter.To ||
                                         filter.VendorFilter.Vendors.Contains(g.Vendor.Name)
                                  )
                                 .Skip(lowerBound)
                                 .Take(upperBound - lowerBound)
                                 .ToList();
            return MiddlewareMappings.Map<List<BassGuitarDataModel>>(guitars);
        }

        public IEnumerable<string> GetBassGuitarVendors()
        {
            return _repoProvider.BassGuitarRepository
                .GetAll()
                .Select(guitar => guitar.Vendor.Name)
                .Distinct()
                .ToList();
        }

        public int GetBassGuitarAmount()
        {
            return _repoProvider.BassGuitarRepository.GetItemAmount();
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.ElectricGuitarRepository.GetAll()
                                 .Where(g =>
                                   filter.PriceFilter != null && filter.VendorFilter != null ?
                                       filter.PriceFilter.From <= g.Price && g.Price <= filter.PriceFilter.To
                                           && filter.VendorFilter.Vendors.Contains(g.Vendor.Name)
                                   : filter.PriceFilter.From <= g.Price && g.Price <= filter.PriceFilter.To ||
                                         filter.VendorFilter.Vendors.Contains(g.Vendor.Name)
                                  )
                                 .Skip(lowerBound)
                                 .Take(upperBound - lowerBound)
                                 .ToList();
            return MiddlewareMappings.Map<List<ElectricGuitarDataModel>>(guitars);
        }

        public IEnumerable<string> GetElectricGuitarVendors()
        {
            return _repoProvider.ElectricGuitarRepository
                .GetAll()
                .Select(guitar => guitar.Vendor.Name)
                .Distinct()
                .ToList();
        }

        public int GetElectriGuitarAmount()
        {
            return _repoProvider.ElectricGuitarRepository.GetItemAmount();
        }

        public ILegatoBusinessLayerWorker Get()
        {
            return new LegatoBusinessLayerWorker(_repoProvider);
        }
        
        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repoProvider.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
