using Ninject;
using System.Linq;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using Legato.ServiceContracts;
using System.Collections.Generic;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL
{
    public class LegatoBusinessLayerWorker : ILegatoBusinessLayerWorker
    {
        private IGuitarUnitOfWork _unitOfWork;
        private IRepositoryProvider _repoProvider;

        static LegatoBusinessLayerWorker()
        {
        }

        [Inject]
        public LegatoBusinessLayerWorker(IRepositoryProvider repoProvider)
        {
            //var ninjectKernel = new StandardKernel();
            //_unitOfWork = ninjectKernel.Get<IGuitarUnitOfWork>();
            _repoProvider = repoProvider;
            MiddlewareMappings.CreateMappings();
        }

        public IEnumerable<GuitarDataModel> GetAllGuitars()
        {
            var guitars = new List<GuitarDataModel>();

            guitars.AddRange(GetAllAcousticClassicalGuitars());
            guitars.AddRange(GetAllAcousticWesternGuitars());
            guitars.AddRange(GetAllElectroGuitars());
            guitars.AddRange(GetAllBassGuitars());

            return guitars;
        }

        public IEnumerable<GuitarDataModel> GetGuitarsByPrice(short from, short to)
        {
            return GetAllGuitars().Where(g => from <= g.StockPrice && g.StockPrice <= to);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAcousticClassicalGuitarsByPrice(short from, short to)
        {
            return GetAllAcousticClassicalGuitars().Where(g => from <= g.StockPrice && g.StockPrice <= to);
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByPrice(short from, short to)
        {
            return GetAllAcousticWesternGuitars().Where(g => from <= g.StockPrice && g.StockPrice <= to);
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByPrice(short from, short to)
        {
            return GetAllBassGuitars().Where(g => from <= g.StockPrice && g.StockPrice <= to);
        }

        public IEnumerable<ElectroGuitarDataModel> GetElectroGuitarsByPrice(short from, short to)
        {
            return GetAllElectroGuitars().Where(g => from <= g.StockPrice && g.StockPrice <= to);
        }

        public IEnumerable<AcousticClassicalGuitarDataModel> GetAllAcousticClassicalGuitars()
        {
            return MiddlewareMappings.Map<IEnumerable<AcousticClassicalGuitarModel>, IEnumerable<AcousticClassicalGuitarDataModel>>(_repoProvider.AcousticClassicalGuitarRepository.GetAll());
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAllAcousticWesternGuitars()
        {
            return MiddlewareMappings.Map<IEnumerable<AcousticWesternGuitarModel>, IEnumerable<AcousticWesternGuitarDataModel>>(_repoProvider.AcousticWesternGuitarRepository.GetAll());
        }

        public IEnumerable<ElectroGuitarDataModel> GetAllElectroGuitars()
        {
            return MiddlewareMappings.Map<IEnumerable<ElectroGuitarModel>, IEnumerable<ElectroGuitarDataModel>>(_repoProvider.ElectroGuitarRepository.GetAll());
        }

        public IEnumerable<BassGuitarDataModel> GetAllBassGuitars()
        {
            return MiddlewareMappings.Map<IEnumerable<BassGuitarModel>, IEnumerable<BassGuitarDataModel>>(_repoProvider.BassGuitarRepository.GetAll());
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
            return MiddlewareMappings.Map<IEnumerable<AcousticClassicalGuitarModel>, IEnumerable<AcousticClassicalGuitarDataModel>>(_repoProvider.AcousticClassicalGuitarRepository.FindByVendor(vendor));
        }

        public IEnumerable<AcousticWesternGuitarDataModel> GetAcousticWesternGuitarsByVendor(string vendor)
        {
            return MiddlewareMappings.Map<IEnumerable<AcousticWesternGuitarModel>, IEnumerable<AcousticWesternGuitarDataModel>>(_repoProvider.AcousticWesternGuitarRepository.FindByVendor(vendor));
        }

        public IEnumerable<ElectroGuitarDataModel> GetElectroGuitarsByVendor(string vendor)
        {
            return MiddlewareMappings.Map<IEnumerable<ElectroGuitarModel>, IEnumerable<ElectroGuitarDataModel>>(_repoProvider.ElectroGuitarRepository.FindByVendor(vendor));
        }

        public IEnumerable<BassGuitarDataModel> GetBassGuitarsByVendor(string vendor)
        {
            return MiddlewareMappings.Map<IEnumerable<BassGuitarModel>, IEnumerable<BassGuitarDataModel>>(_repoProvider.BassGuitarRepository.FindByVendor(vendor));
        }

        public ILegatoBusinessLayerWorker Get()
        {
            return new LegatoBusinessLayerWorker(_repoProvider);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repoProvider.AcousticClassicalGuitarRepository.Dispose();
                _repoProvider.AcousticWesternGuitarRepository.Dispose();
                _repoProvider.ElectroGuitarRepository.Dispose();
                _repoProvider.BassGuitarRepository.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
