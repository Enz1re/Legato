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

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(short from, short to)
        {
            return GetAllAcousticClassicalGuitars().Where(g => from <= g.Price && g.Price <= to);
        }

        public IEnumerable<VendorDataModel> GetAcousticClassicalGuitarVendors()
        {
            return GetAllAcousticClassicalGuitars().Select(guitar => guitar.Vendor).Distinct(new VendorEqualityComparer());
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(short from, short to)
        {
            return GetAllAcousticWesternGuitars().Where(g => from <= g.Price && g.Price <= to);
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(short from, short to)
        {
            return GetAllBassGuitars().Where(g => from <= g.Price && g.Price <= to);
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByPrice(short from, short to)
        {
            return GetAllElectricGuitars().Where(g => from <= g.Price && g.Price <= to);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars()
        {
            return MiddlewareMappings.Map<List<AcousticClassicalGuitarDataModel>>(_repoProvider.AcousticClassicalGuitarRepository.GetAll());
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars()
        {
            return MiddlewareMappings.Map<List<AcousticWesternGuitarDataModel>>(_repoProvider.AcousticWesternGuitarRepository.GetAll());
        }

        public IEnumerable<VendorDataModel> GetAcousticWesternGuitarVendors()
        {
            return GetAllAcousticWesternGuitars().Select(guitar => guitar.Vendor).Distinct(new VendorEqualityComparer());
        }

        public IEnumerable<ElectricGuitarDataModel> GetAllElectricGuitars()
        {
            return MiddlewareMappings.Map<List<ElectricGuitarDataModel>>(_repoProvider.ElectricGuitarRepository.GetAll());
        }

        public IEnumerable<VendorDataModel> GetElectricGuitarVendors()
        {
            return GetAllElectricGuitars().Select(guitar => guitar.Vendor).Distinct(new VendorEqualityComparer());
        }

        public IEnumerable<BassGuitarDataModel> GetAllBassGuitars()
        {
            return MiddlewareMappings.Map<List<BassGuitarDataModel>>(_repoProvider.BassGuitarRepository.GetAll());
        }

        public IEnumerable<VendorDataModel> GetBassGuitarVendors()
        {
            return GetAllBassGuitars().Select(guitar => guitar.Vendor).Distinct(new VendorEqualityComparer());
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendor(string vendor)
        {
            return MiddlewareMappings.Map<List<AcousticClassicalGuitarDataModel>>(_repoProvider.AcousticClassicalGuitarRepository.FindByVendor(vendor));
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendor(string vendor)
        {
            return MiddlewareMappings.Map<List<AcousticWesternGuitarDataModel>>(_repoProvider.AcousticWesternGuitarRepository.FindByVendor(vendor));
        }

        public IEnumerable<ElectricGuitarDataModel> GetElectricGuitarsByVendor(string vendor)
        {
            return MiddlewareMappings.Map<List<ElectricGuitarDataModel>>(_repoProvider.ElectricGuitarRepository.FindByVendor(vendor));
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendor(string vendor)
        {
            return MiddlewareMappings.Map<List<BassGuitarDataModel>>(_repoProvider.BassGuitarRepository.FindByVendor(vendor));
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
