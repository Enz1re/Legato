using Legato.ServiceDAL;
using System.Collections.Generic;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.ViewModels;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.Service
{
    public class LegatoServiceWorker : ILegatoServiceWorker
    {
        private IGuitarUnitOfWork _unitOfWork;

        public LegatoServiceWorker(IGuitarUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<GuitarViewModel> GetAllGuitars()
        {
            return ServiceMappings.Map<IEnumerable<GuitarDataModel>, IEnumerable<GuitarViewModel>>(_unitOfWork.GuitarsCommon.GetAll());
        }

        public IEnumerable<GuitarViewModel> GetGuitarsByPrice(short from, short to)
        {
            return ServiceMappings.Map<IEnumerable<GuitarDataModel>, IEnumerable<GuitarViewModel>>(_unitOfWork.GuitarsCommon.FindByCost(from, to));
        }

        public IEnumerable<GuitarViewModel> GetGuitarsByVendor(string vendor)
        {
            return ServiceMappings.Map<IEnumerable<GuitarDataModel>, IEnumerable<GuitarViewModel>>(_unitOfWork.GuitarsCommon.FindByVendor(vendor));
        }

        public IEnumerable<AcousticClassicalGuitarViewModel> GetAcousticClassicalGuitarsByPrice(short from, short to)
        {
            return ServiceMappings.Map<IEnumerable<AcousticClassicalGuitarDataModel>, IEnumerable<AcousticClassicalGuitarViewModel>>(_unitOfWork.ClassicAcousticGuitars.FindByCost(from, to));
        }

        public IEnumerable<AcousticWesternGuitarViewModel> GetAcousticWesternGuitarsByPrice(short from, short to)
        {
            return ServiceMappings.Map<IEnumerable<AcousticWesternGuitarDataModel>, IEnumerable<AcousticWesternGuitarViewModel>>(_unitOfWork.WesternAcousticGuitars.FindByCost(from, to));
        }

        public IEnumerable<BassGuitarViewModel> GetBassGuitarsByPrice(short from, short to)
        {
            return ServiceMappings.Map<IEnumerable<BassGuitarDataModel>, IEnumerable<BassGuitarViewModel>>(_unitOfWork.BassGuitars.FindByCost(from, to));
        }

        public IEnumerable<ElectroGuitarViewModel> GetElectroGuitarsByPrice(short from, short to)
        {
            return ServiceMappings.Map<IEnumerable<ElectroGuitarDataModel>, IEnumerable<ElectroGuitarViewModel>>(_unitOfWork.ElectroGuitars.FindByCost(from, to));
        }

        public IEnumerable<AcousticClassicalGuitarViewModel> GetAllAcousticClassicalGuitars()
        {
            return ServiceMappings.Map<IEnumerable<AcousticClassicalGuitarDataModel>, IEnumerable<AcousticClassicalGuitarViewModel>>(_unitOfWork.ClassicAcousticGuitars.GetAll());
        }

        public IEnumerable<AcousticWesternGuitarViewModel> GetAllAcousticWesternGuitars()
        {
            return ServiceMappings.Map<IEnumerable<AcousticWesternGuitarDataModel>, IEnumerable<AcousticWesternGuitarViewModel>>(_unitOfWork.WesternAcousticGuitars.GetAll());
        }

        public IEnumerable<ElectroGuitarViewModel> GetAllElectroGuitars()
        {
            return ServiceMappings.Map<IEnumerable<ElectroGuitarDataModel>, IEnumerable<ElectroGuitarViewModel>>(_unitOfWork.ElectroGuitars.GetAll());
        }

        public IEnumerable<BassGuitarViewModel> GetAllBassGuitars()
        {
            return ServiceMappings.Map<IEnumerable<BassGuitarDataModel>, IEnumerable<BassGuitarViewModel>>(_unitOfWork.BassGuitars.GetAll());
        }

        public IEnumerable<AcousticClassicalGuitarViewModel> GetAcousticClassicalGuitarsByVendor(string vendor)
        {
            return ServiceMappings.Map<IEnumerable<AcousticClassicalGuitarDataModel>, IEnumerable<AcousticClassicalGuitarViewModel>>(_unitOfWork.ClassicAcousticGuitars.FindByVendor(vendor));
        }

        public IEnumerable<AcousticWesternGuitarViewModel> GetAcousticWesternGuitarsByVendor(string vendor)
        {
            return ServiceMappings.Map<IEnumerable<AcousticWesternGuitarDataModel>, IEnumerable<AcousticWesternGuitarViewModel>>(_unitOfWork.WesternAcousticGuitars.FindByVendor(vendor));
        }

        public IEnumerable<ElectroGuitarViewModel> GetElectroGuitarsByVendor(string vendor)
        {
            return ServiceMappings.Map<IEnumerable<ElectroGuitarDataModel>, IEnumerable<ElectroGuitarViewModel>>(_unitOfWork.ElectroGuitars.FindByVendor(vendor));
        }

        public IEnumerable<BassGuitarViewModel> GetBassGuitarsByVendor(string vendor)
        {
            return ServiceMappings.Map<IEnumerable<BassGuitarDataModel>, IEnumerable<BassGuitarViewModel>>(_unitOfWork.BassGuitars.FindByVendor(vendor));
        }
    }
}