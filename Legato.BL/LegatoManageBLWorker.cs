using Ninject;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using Legato.MiddlewareContracts;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL
{
    public class LegatoManageBLWorker : ILegatoManageBLWorker
    {
        private IRepositoryProvider _repoProvider;

        [Inject]
        public LegatoManageBLWorker(IRepositoryProvider repoProvider)
        {
            _repoProvider = repoProvider;
        }

        public void AddAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar)
        {
            _repoProvider.AcousticClassicalGuitarRepository.Create(MiddlewareMappings.Map<AcousticClassicalGuitarModel>(guitar));
        }

        public void EditAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar)
        {
            _repoProvider.AcousticClassicalGuitarRepository.Update(MiddlewareMappings.Map<AcousticClassicalGuitarModel>(guitar));
        }

        public void RemoveAcousticClassicalGuitar(int id)
        {
            _repoProvider.AcousticClassicalGuitarRepository.Delete(id);
        }

        public void AddAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar)
        {
            _repoProvider.AcousticWesternGuitarRepository.Create(MiddlewareMappings.Map<AcousticWesternGuitarModel>(guitar));
        }

        public void EditAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar)
        {
            _repoProvider.AcousticWesternGuitarRepository.Update(MiddlewareMappings.Map<AcousticWesternGuitarModel>(guitar));
        }

        public void RemoveAcousticWesternGuitar(int id)
        {
            _repoProvider.AcousticWesternGuitarRepository.Delete(id);
        }

        public void AddElectricGuitar(ElectricGuitarDataModel guitar)
        {
            _repoProvider.ElectricGuitarRepository.Create(MiddlewareMappings.Map<ElectricGuitarModel>(guitar));
        }

        public void EditElectricGuitar(ElectricGuitarDataModel guitar)
        {
            _repoProvider.ElectricGuitarRepository.Update(MiddlewareMappings.Map<ElectricGuitarModel>(guitar));
        }

        public void RemoveElectricGuitar(int id)
        {
            _repoProvider.ElectricGuitarRepository.Delete(id);
        }

        public void AddBassGuitar(BassGuitarDataModel guitar)
        {
            _repoProvider.BassGuitarRepository.Create(MiddlewareMappings.Map<BassGuitarModel>(guitar));
        }

        public void EditBassGuitar(BassGuitarDataModel guitar)
        {
            _repoProvider.BassGuitarRepository.Update(MiddlewareMappings.Map<BassGuitarModel>(guitar));
        }

        public void RemoveBassGuitar(int id)
        {
            _repoProvider.BassGuitarRepository.Delete(id);
        }

        public ILegatoManageBLWorker Get()
        {
            return new LegatoManageBLWorker(_repoProvider);
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
