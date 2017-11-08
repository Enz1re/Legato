using Ninject;
using System.Linq;
using Legato.DAL.Models;
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
            var guitars = ApplyFilteringFor(_repoProvider.AcousticClassicalGuitarRepository, filter);

            return MiddlewareMappings.Map<List<AcousticClassicalGuitarDataModel>>(guitars.Skip(lowerBound)
                                                                                         .Take(upperBound - lowerBound)
                                                                                         .ToList());
        }

        public IEnumerable<string> GetAcousticClassicalGuitarVendors()
        {
            return _repoProvider.AcousticClassicalGuitarRepository
                .GetAll()
                .Select(guitar => guitar.Vendor.Name)
                .Distinct()
                .ToList();
        }

        public int GetAcousticClassicalGuitarAmount(FilterDataModel filter)
        {
            var guitars = ApplyFilteringFor(_repoProvider.AcousticClassicalGuitarRepository, filter);

            return guitars.Count();
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

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            var guitars = ApplyFilteringFor(_repoProvider.AcousticWesternGuitarRepository, filter);

            return MiddlewareMappings.Map<List<AcousticWesternGuitarDataModel>>(guitars.Skip(lowerBound)
                                                                                       .Take(upperBound - lowerBound)
                                                                                       .ToList());
        }

        public IEnumerable<string> GetAcousticWesternGuitarVendors()
        {
            return _repoProvider.AcousticWesternGuitarRepository
                .GetAll()
                .Select(guitar => guitar.Vendor.Name)
                .Distinct()
                .ToList();
        }

        public int GetAcousticWesternGuitarAmount(FilterDataModel filter)
        {
            var guitars = ApplyFilteringFor(_repoProvider.AcousticWesternGuitarRepository, filter);

            return guitars.Count();
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

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            var guitars = ApplyFilteringFor(_repoProvider.ElectricGuitarRepository, filter);

            return MiddlewareMappings.Map<List<ElectricGuitarDataModel>>(guitars.Skip(lowerBound)
                                                                                .Take(upperBound - lowerBound)
                                                                                .ToList());
        }

        public IEnumerable<string> GetElectricGuitarVendors()
        {
            return _repoProvider.ElectricGuitarRepository
                .GetAll()
                .Select(guitar => guitar.Vendor.Name)
                .Distinct()
                .ToList();
        }

        public int GetElectriGuitarAmount(FilterDataModel filter)
        {
            var guitars = ApplyFilteringFor(_repoProvider.ElectricGuitarRepository, filter);

            return guitars.Count();
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

        public IEnumerable<BassGuitarDataModel> GetBassGuitars(FilterDataModel filter, int lowerBound, int upperBound)
        {
            var guitars = ApplyFilteringFor(_repoProvider.BassGuitarRepository, filter);

            return MiddlewareMappings.Map<List<BassGuitarDataModel>>(guitars.Skip(lowerBound)
                                                                            .Take(upperBound - lowerBound)
                                                                            .ToList());
        }

        public IEnumerable<string> GetBassGuitarVendors()
        {
            return _repoProvider.BassGuitarRepository
                .GetAll()
                .Select(guitar => guitar.Vendor.Name)
                .Distinct()
                .ToList();
        }

        public int GetBassGuitarAmount(FilterDataModel filter)
        {
            var guitars = ApplyFilteringFor(_repoProvider.BassGuitarRepository, filter);

            return guitars.Count();
        }

        public IEnumerable<BassGuitarDataModel> GetSortedBassGuitarsByPrice(FilterDataModel filter, int lowerBound, int upperBound, SortDirection sortDirection)
        {
            var guitars = ApplyFilteringFor(_repoProvider.AcousticWesternGuitarRepository, filter);

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
            var guitars = ApplyFilteringFor(_repoProvider.AcousticWesternGuitarRepository, filter);

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

        public ILegatoBusinessLayerWorker Get()
        {
            return new LegatoBusinessLayerWorker(_repoProvider);
        }
        
        private bool PriceFilterExists(PriceFilterDataModel filter)
        {
            return filter != null && filter.From != null && filter.To != null;
        }

        private bool VendorFilterExists(VendorFilterDataModel filter)
        {
            return filter != null && filter.Vendors != null;
        }

        private IQueryable<TGuitar> ApplyFilteringFor<TGuitar>(IGuitarRepository<TGuitar> repo, FilterDataModel filter) where TGuitar : GuitarModel
        {
            var from = filter.PriceFilter?.From;
            var to = filter.PriceFilter?.To;
            var vendors = filter.VendorFilter?.Vendors;

            var all = repo.GetAll();
            if (PriceFilterExists(filter.PriceFilter))
            {
                all = all.Where(g => from <= g.Price && g.Price <= to);
            }
            if (VendorFilterExists(filter.VendorFilter))
            {
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
