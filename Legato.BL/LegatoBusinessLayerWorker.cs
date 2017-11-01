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

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(int from, int to, int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.AcousticClassicalGuitarRepository.FindByPrice(from, to)
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

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(int from, int to, int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.AcousticWesternGuitarRepository.FindByPrice(from, to)
                              .Skip(lowerBound)
                              .Take(upperBound - lowerBound)
                              .ToList();
            return MiddlewareMappings.Map<List<AcousticWesternGuitarDataModel>>(guitars);
        }

        public int GetAcousticClassicalGuitarAmount()
        {
            return _repoProvider.AcousticClassicalGuitarRepository.GetItemAmount();
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(int from, int to, int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.BassGuitarRepository.FindByPrice(from, to)
                                 .Skip(lowerBound)
                                 .Take(upperBound - lowerBound)
                                 .ToList();
            return MiddlewareMappings.Map<List<BassGuitarDataModel>>(guitars);
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByPrice(int from, int to, int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.ElectricGuitarRepository.FindByPrice(from, to)
                                 .Skip(lowerBound)
                                 .Take(upperBound - lowerBound)
                                 .ToList();
            return MiddlewareMappings.Map<List<ElectricGuitarDataModel>>(guitars);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars(int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.AcousticClassicalGuitarRepository.GetAll()
                              .Skip(lowerBound)
                              .Take(upperBound - lowerBound)
                              .ToList();
            return MiddlewareMappings.Map<List<AcousticClassicalGuitarDataModel>>(guitars);
        }

        public int GetAcousticWesternGuitarAmount()
        {
            return _repoProvider.AcousticWesternGuitarRepository.GetItemAmount();
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars(int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.AcousticWesternGuitarRepository.GetAll()
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

        public IEnumerable<ElectricGuitarDataModel> GetAllElectricGuitars(int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.ElectricGuitarRepository.GetAll()
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

        public IEnumerable<BassGuitarDataModel> GetAllBassGuitars(int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.BassGuitarRepository.GetAll()
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

        public int GetElectriGuitarAmount()
        {
            return _repoProvider.ElectricGuitarRepository.GetItemAmount();
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.AcousticClassicalGuitarRepository.FindByVendors(vendors)
                              .Skip(lowerBound)
                              .Take(upperBound - lowerBound)
                              .ToList();
            return MiddlewareMappings.Map<List<AcousticClassicalGuitarDataModel>>(guitars);
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.AcousticWesternGuitarRepository.FindByVendors(vendors)
                                 .Skip(lowerBound)
                                 .Take(upperBound - lowerBound)
                                 .ToList();
            return MiddlewareMappings.Map<List<AcousticWesternGuitarDataModel>>(guitars);
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.ElectricGuitarRepository.FindByVendors(vendors)
                                 .Skip(lowerBound)
                                 .Take(upperBound - lowerBound)
                                 .ToList();
            return MiddlewareMappings.Map<List<ElectricGuitarDataModel>>(guitars);
        }

        public int GetBassGuitarAmount()
        {
            return _repoProvider.BassGuitarRepository.GetItemAmount();
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendors(string[] vendors, int lowerBound, int upperBound)
        {
            var guitars = _repoProvider.BassGuitarRepository.FindByVendors(vendors)
                                 .Skip(lowerBound)
                                 .Take(upperBound - lowerBound)
                                 .ToList();
            return MiddlewareMappings.Map<List<BassGuitarDataModel>>(guitars);
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
