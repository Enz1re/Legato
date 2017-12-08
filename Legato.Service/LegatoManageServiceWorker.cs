using Ninject;
using Legato.ServiceDAL;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.ViewModels;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.Service
{
    public class LegatoManageServiceWorker : ILegatoManageServiceWorker
    {
        private IGuitarUnitOfWork _unitOfWork;

        [Inject]
        public LegatoManageServiceWorker(IGuitarUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(GuitarViewModel guitar, GuitarType type)
        {
            switch (type)
            {
                case GuitarType.Classical:
                    _unitOfWork.ClassicAcousticGuitars.Add(ServiceMappings.Map<AcousticClassicalGuitarDataModel>(guitar));
                    break;
                case GuitarType.Western:
                    _unitOfWork.WesternAcousticGuitars.Add(ServiceMappings.Map<AcousticWesternGuitarDataModel>(guitar));
                    break;
                case GuitarType.Electric:
                    _unitOfWork.ElectricGuitars.Add(ServiceMappings.Map<ElectricGuitarDataModel>(guitar));
                    break;
                case GuitarType.Bass:
                    _unitOfWork.BassGuitars.Add(ServiceMappings.Map<BassGuitarDataModel>(guitar));
                    break;
            }
        }
        
        public void Edit(GuitarViewModel guitar, GuitarType type)
        {
            switch (type)
            {
                case GuitarType.Classical:
                    _unitOfWork.ClassicAcousticGuitars.Update(ServiceMappings.Map<AcousticClassicalGuitarDataModel>(guitar));
                    break;
                case GuitarType.Western:
                    _unitOfWork.WesternAcousticGuitars.Update(ServiceMappings.Map<AcousticWesternGuitarDataModel>(guitar));
                    break;
                case GuitarType.Electric:
                    _unitOfWork.ElectricGuitars.Update(ServiceMappings.Map<ElectricGuitarDataModel>(guitar));
                    break;
                case GuitarType.Bass:
                    _unitOfWork.BassGuitars.Update(ServiceMappings.Map<BassGuitarDataModel>(guitar));
                    break;
            }
        }

        public void Remove(GuitarViewModel guitar, GuitarType type)
        {
            switch (type)
            {
                case GuitarType.Classical:
                    _unitOfWork.ClassicAcousticGuitars.Delete(ServiceMappings.Map<AcousticClassicalGuitarDataModel>(guitar));
                    break;
                case GuitarType.Western:
                    _unitOfWork.WesternAcousticGuitars.Delete(ServiceMappings.Map<AcousticWesternGuitarDataModel>(guitar));
                    break;
                case GuitarType.Electric:
                    _unitOfWork.ElectricGuitars.Delete(ServiceMappings.Map<ElectricGuitarDataModel>(guitar));
                    break;
                case GuitarType.Bass:
                    _unitOfWork.BassGuitars.Delete(ServiceMappings.Map<BassGuitarDataModel>(guitar));
                    break;
            }
        }
    }
}