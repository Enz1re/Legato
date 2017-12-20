using Ninject;
using System.Linq;
using Legato.DAL.Models;
using Legato.BL.Interfaces;
using Legato.DAL.Interfaces;
using System.Collections.Generic;
using Legato.MiddlewareContracts;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL.Workers
{
    public class LegatoGuitarBLWorker : ILegatoGuitarBLWorker
    {
        private IRepositoryProvider _repoProvider;

        [Inject]
        public LegatoGuitarBLWorker(IRepositoryProvider repoProvider)
        {
            _repoProvider = repoProvider;
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            var guitars = ApplyFilteringFor(_repoProvider.AcousticClassicalGuitarRepository, filter);
            
            return MiddlewareMappings.Map<List<AcousticClassicalGuitarDataModel>>(guitars.Skip(lowerBound)
                                                                                         .Take(upperBound - lowerBound)
                                                                                         .ToList());
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetSortedAcousticClassicalGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection)
        {
            var guitars = ApplyFilteringFor(_repoProvider.AcousticClassicalGuitarRepository, filter);

            if (sortDirection == SortDirection.Ascending)
                return MiddlewareMappings.Map<List<AcousticClassicalGuitarDataModel>>(guitars.OrderBy(g => g.Price)
                                                                                             .Skip(lowerBound)
                                                                                             .Take(upperBound - lowerBound)
                                                                                             .ToList());
            else
                return MiddlewareMappings.Map<List<AcousticClassicalGuitarDataModel>>(guitars.OrderByDescending(g => g.Price)
                                                                                             .Skip(lowerBound)
                                                                                             .Take(upperBound - lowerBound)
                                                                                             .ToList());
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetSortedAcousticClassicalGuitarsByVendor(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection)
        {
            var guitars = ApplyFilteringFor(_repoProvider.AcousticClassicalGuitarRepository, filter);

            if (sortDirection == SortDirection.Ascending)
                return MiddlewareMappings.Map<List<AcousticClassicalGuitarDataModel>>(guitars.OrderBy(g => g.Vendor.Name)
                                                                                             .Skip(lowerBound)
                                                                                             .Take(upperBound - lowerBound)
                                                                                             .ToList());
            else
                return MiddlewareMappings.Map<List<AcousticClassicalGuitarDataModel>>(guitars.OrderByDescending(g => g.Vendor.Name)
                                                                                             .Skip(lowerBound)
                                                                                             .Take(upperBound - lowerBound)
                                                                                             .ToList());
        }

        public IEnumerable<VendorDataModel> GetAcousticClassicalGuitarVendors()
        {
            return MiddlewareMappings.Map<List<VendorDataModel>>(_repoProvider.AcousticClassicalGuitarRepository
                                                                              .GetAll()
                                                                              .Select(guitar => guitar.Vendor)
                                                                              .ToList());
        }

        public int GetAcousticClassicalGuitarAmount(FilterDataModel filter)
        {
            var guitars = ApplyFilteringFor(_repoProvider.AcousticClassicalGuitarRepository, filter);

            return guitars.Count();
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            var guitars = ApplyFilteringFor(_repoProvider.AcousticWesternGuitarRepository, filter);

            return MiddlewareMappings.Map<List<AcousticWesternGuitarDataModel>>(guitars.Skip(lowerBound)
                                                                                       .Take(upperBound - lowerBound)
                                                                                       .ToList());
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetSortedAcousticWesternGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection)
        {
            var guitars = ApplyFilteringFor(_repoProvider.AcousticWesternGuitarRepository, filter);

            if (sortDirection == SortDirection.Ascending)
                return MiddlewareMappings.Map<List<AcousticWesternGuitarDataModel>>(guitars.OrderBy(g => g.Price)
                                                                                           .Skip(lowerBound)
                                                                                           .Take(upperBound - lowerBound)
                                                                                           .ToList());
            else
                return MiddlewareMappings.Map<List<AcousticWesternGuitarDataModel>>(guitars.OrderByDescending(g => g.Price)
                                                                                           .Skip(lowerBound)
                                                                                           .Take(upperBound - lowerBound)
                                                                                           .ToList());
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetSortedAcousticWesternGuitarsByVendor(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection)
        {
            var guitars = ApplyFilteringFor(_repoProvider.AcousticWesternGuitarRepository, filter);

            if (sortDirection == SortDirection.Ascending)
                return MiddlewareMappings.Map<List<AcousticWesternGuitarDataModel>>(guitars.OrderBy(g => g.Vendor.Name)
                                                                                           .Skip(lowerBound)
                                                                                           .Take(upperBound - lowerBound)
                                                                                           .ToList());
            else
                return MiddlewareMappings.Map<List<AcousticWesternGuitarDataModel>>(guitars.OrderByDescending(g => g.Vendor.Name)
                                                                                           .Skip(lowerBound)
                                                                                           .Take(upperBound - lowerBound)
                                                                                           .ToList());
        }

        public IEnumerable<VendorDataModel> GetAcousticWesternGuitarVendors()
        {
            return MiddlewareMappings.Map<List<VendorDataModel>>(_repoProvider.AcousticWesternGuitarRepository
                                                                              .GetAll()
                                                                              .Select(guitar => guitar.Vendor)
                                                                              .ToList());
        }

        public int GetAcousticWesternGuitarAmount(FilterDataModel filter)
        {
            var guitars = ApplyFilteringFor(_repoProvider.AcousticWesternGuitarRepository, filter);

            return guitars.Count();
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            var guitars = ApplyFilteringFor(_repoProvider.ElectricGuitarRepository, filter);

            return MiddlewareMappings.Map<List<ElectricGuitarDataModel>>(guitars.Skip(lowerBound)
                                                                                .Take(upperBound - lowerBound)
                                                                                .ToList());
        }

        public IEnumerable<ElectricGuitarDataModel> GetSortedElectricGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection)
        {
            var guitars = ApplyFilteringFor(_repoProvider.ElectricGuitarRepository, filter);

            if (sortDirection == SortDirection.Ascending)
                return MiddlewareMappings.Map<List<ElectricGuitarDataModel>>(guitars.OrderBy(g => g.Price)
                                                                                    .Skip(lowerBound)
                                                                                    .Take(upperBound - lowerBound)
                                                                                    .ToList());
            else
                return MiddlewareMappings.Map<List<ElectricGuitarDataModel>>(guitars.OrderByDescending(g => g.Price)
                                                                                    .Skip(lowerBound)
                                                                                    .Take(upperBound - lowerBound)
                                                                                    .ToList());
        }

        public IEnumerable<ElectricGuitarDataModel> GetSortedElectricGuitarsByVendor(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection)
        {
            var guitars = ApplyFilteringFor(_repoProvider.ElectricGuitarRepository, filter);

            if (sortDirection == SortDirection.Ascending)
                return MiddlewareMappings.Map<List<ElectricGuitarDataModel>>(guitars.OrderBy(g => g.Vendor.Name)
                                                                                    .Skip(lowerBound)
                                                                                    .Take(upperBound - lowerBound)
                                                                                    .ToList());
            else
                return MiddlewareMappings.Map<List<ElectricGuitarDataModel>>(guitars.OrderByDescending(g => g.Vendor.Name)
                                                                                    .Skip(lowerBound)
                                                                                    .Take(upperBound - lowerBound)
                                                                                    .ToList());
        }

        public IEnumerable<VendorDataModel> GetElectricGuitarVendors()
        {
            return MiddlewareMappings.Map<List<VendorDataModel>>(_repoProvider.ElectricGuitarRepository
                                                                              .GetAll()
                                                                              .Select(guitar => guitar.Vendor)
                                                                              .ToList());
        }

        public int GetElectriGuitarAmount(FilterDataModel filter)
        {
            var guitars = ApplyFilteringFor(_repoProvider.ElectricGuitarRepository, filter);

            return guitars.Count();
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            var guitars = ApplyFilteringFor(_repoProvider.BassGuitarRepository, filter);

            return MiddlewareMappings.Map<List<BassGuitarDataModel>>(guitars.Skip(lowerBound)
                                                                            .Take(upperBound - lowerBound)
                                                                            .ToList());
        }

        public IEnumerable<BassGuitarDataModel> GetSortedBassGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection)
        {
            var guitars = ApplyFilteringFor(_repoProvider.BassGuitarRepository, filter);

            if (sortDirection == SortDirection.Ascending)
                return MiddlewareMappings.Map<List<BassGuitarDataModel>>(guitars.OrderBy(g => g.Price)
                                                                                .Skip(lowerBound)
                                                                                .Take(upperBound - lowerBound)
                                                                                .ToList());
            else
                return MiddlewareMappings.Map<List<BassGuitarDataModel>>(guitars.OrderByDescending(g => g.Price)
                                                                                .Skip(lowerBound)
                                                                                .Take(upperBound - lowerBound)
                                                                                .ToList());
        }

        public IEnumerable<BassGuitarDataModel> GetSortedBassGuitarsByVendor(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection)
        {
            var guitars = ApplyFilteringFor(_repoProvider.BassGuitarRepository, filter);

            if (sortDirection == SortDirection.Ascending)
                return MiddlewareMappings.Map<List<BassGuitarDataModel>>(guitars.OrderBy(g => g.Vendor.Name)
                                                                                .Skip(lowerBound)
                                                                                .Take(upperBound - lowerBound)
                                                                                .ToList());
            else
                return MiddlewareMappings.Map<List<BassGuitarDataModel>>(guitars.OrderByDescending(g => g.Vendor.Name)
                                                                                .Skip(lowerBound)
                                                                                .Take(upperBound - lowerBound)
                                                                                .ToList());
        }

        public IEnumerable<VendorDataModel> GetBassGuitarVendors()
        {
            return MiddlewareMappings.Map<List<VendorDataModel>>(_repoProvider.BassGuitarRepository
                                                                              .GetAll()
                                                                              .Select(guitar => guitar.Vendor)
                                                                              .ToList());
        }

        public int GetBassGuitarAmount(FilterDataModel filter)
        {
            var guitars = ApplyFilteringFor(_repoProvider.BassGuitarRepository, filter);

            return guitars.Count();
        }
        
        private bool PriceFilterExists(PriceFilterDataModel filter)
        {
            return filter != null && filter.From != null && filter.To != null;
        }

        private bool VendorFilterExists(VendorFilterDataModel filter)
        {
            return filter != null && filter.Vendors != null;
        }

        private bool SearchItemsExist(string[] searchItems)
        {
            return searchItems != null && searchItems.Length > 0;
        }

        private IQueryable<TGuitar> ApplyFilteringFor<TGuitar>(IGuitarRepository<TGuitar> repo, FilterDataModel filter) where TGuitar : GuitarModel
        {
            var all = repo.GetAll();

            if (SearchItemsExist(filter.SearchItems))
            {
                var searchItems = filter.SearchItems;
                all = all.Where(guitar => searchItems.All(item => guitar.Vendor.Name.ToLower().Contains(item) || guitar.Model.ToLower().Contains(item)));
            }
            if (PriceFilterExists(filter.PriceFilter))
            {
                var from = filter.PriceFilter.From;
                var to = filter.PriceFilter.To;
                all = all.Where(g => from <= g.Price && g.Price <= to);
            }
            if (VendorFilterExists(filter.VendorFilter))
            {
                var vendors = filter.VendorFilter.Vendors.Select(v => v.Name);
                all = all.Where(g => vendors.Contains(g.Vendor.Name));
            }

            return all;
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
