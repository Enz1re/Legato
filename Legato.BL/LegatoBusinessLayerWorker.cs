using Ninject;
using System.Linq;
using Legato.DAL.Interfaces;
using Legato.ServiceContracts;
using System.Collections.Generic;
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

        public IEnumerable<GuitarDataModel> GetAllGuitars()
        {
            var guitars = new List<GuitarDataModel>();

            guitars.AddRange(GetAllAcousticClassicalGuitars());
            guitars.AddRange(GetAllAcousticWesternGuitars());
            guitars.AddRange(GetAllElectricGuitars());
            guitars.AddRange(GetAllBassGuitars());

            return guitars;
        }

        public IEnumerable<string> GetAllVendors()
        {
            return GetAllGuitars().Select(guitar => guitar.Vendor).Distinct();
        }

        public IEnumerable<GuitarDataModel> GetGuitarsByPrice(short from, short to)
        {
            return GetAllGuitars().Where(g => from <= g.Price && g.Price <= to);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(short from, short to)
        {
            return GetAllAcousticClassicalGuitars().Where(g => from <= g.Price && g.Price <= to);
        }

        public IEnumerable<string> GetAcousticClassicalGuitarVendors()
        {
            return GetAllAcousticClassicalGuitars().Select(guitar => guitar.Vendor).Distinct();
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(short from, short to)
        {
            return GetAllAcousticWesternGuitars().Where(g => from <= g.Price && g.Price <= to);
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(short from, short to)
        {
            return GetAllBassGuitars().Where(g => from <= g.Price && g.Price <= to);
        }

        public IEnumerable<ElectroGuitarDataModel> GetElectroGuitarsByPrice(short from, short to)
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

        public IEnumerable<string> GetAcousticWesternGuitarVendors()
        {
            return GetAllAcousticWesternGuitars().Select(guitar => guitar.Vendor).Distinct();
        }

        public IEnumerable<ElectroGuitarDataModel> GetAllElectricGuitars()
        {
            return MiddlewareMappings.Map<List<ElectroGuitarDataModel>>(_repoProvider.ElectroGuitarRepository.GetAll());
        }

        public IEnumerable<string> GetElectricGuitarVendors()
        {
            return GetAllElectricGuitars().Select(guitar => guitar.Vendor).Distinct();
        }

        public IEnumerable<BassGuitarDataModel> GetAllBassGuitars()
        {
            return MiddlewareMappings.Map<List<BassGuitarDataModel>>(_repoProvider.BassGuitarRepository.GetAll());
        }

        public IEnumerable<string> GetBassGuitarVendors()
        {
            return GetAllBassGuitars().Select(guitar => guitar.Vendor).Distinct();
        }

        public IEnumerable<GuitarDataModel> GetGuitarsByVendor(string vendor)
        {
            var guitarsByVendor = new List<GuitarDataModel>();

            guitarsByVendor.AddRange(GetAcousticClassicalGuitarsByVendor(vendor));
            guitarsByVendor.AddRange(GetAcousticWesternGuitarsByVendor(vendor));
            guitarsByVendor.AddRange(GetElectroGuitarsByVendor(vendor));
            guitarsByVendor.AddRange(GetBassGuitarsByVendor(vendor));

            return guitarsByVendor;
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByVendor(string vendor)
        {
            return MiddlewareMappings.Map<List<AcousticClassicalGuitarDataModel>>(_repoProvider.AcousticClassicalGuitarRepository.FindByVendor(vendor));
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendor(string vendor)
        {
            return MiddlewareMappings.Map<List<AcousticWesternGuitarDataModel>>(_repoProvider.AcousticWesternGuitarRepository.FindByVendor(vendor));
        }

        public IEnumerable<ElectroGuitarDataModel> GetElectroGuitarsByVendor(string vendor)
        {
            return MiddlewareMappings.Map<List<ElectroGuitarDataModel>>(_repoProvider.ElectroGuitarRepository.FindByVendor(vendor));
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
