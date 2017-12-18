using System;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL.Interfaces
{
    public interface ILegatoManageBLWorker : IDisposable
    {
        void AddAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar);

        void EditAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar);

        void RemoveAcousticClassicalGuitar(int id);

        void AddAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar);

        void EditAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar);

        void RemoveAcousticWesternGuitar(int id);

        void AddElectricGuitar(ElectricGuitarDataModel guitar);

        void EditElectricGuitar(ElectricGuitarDataModel guitar);

        void RemoveElectricGuitar(int id);

        void AddBassGuitar(BassGuitarDataModel guitar);

        void EditBassGuitar(BassGuitarDataModel guitar);

        void RemoveBassGuitar(int id);

        ILegatoManageBLWorker Get();
    }
}
