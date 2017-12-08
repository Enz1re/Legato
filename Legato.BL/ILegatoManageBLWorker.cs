using System;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.BL
{
    public interface ILegatoManageBLWorker : IDisposable
    {
        void AddAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar);

        void EditAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar);

        void RemoveAcousticClassicalGuitar(AcousticClassicalGuitarDataModel guitar);

        void AddAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar);

        void EditAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar);

        void RemoveAcousticWesternGuitar(AcousticWesternGuitarDataModel guitar);

        void AddElectricGuitar(ElectricGuitarDataModel guitar);

        void EditElectricGuitar(ElectricGuitarDataModel guitar);

        void RemoveElectricGuitar(ElectricGuitarDataModel guitar);

        void AddBassGuitar(BassGuitarDataModel guitar);

        void EditBassGuitar(BassGuitarDataModel guitar);

        void RemoveBassGuitar(BassGuitarDataModel guitar);

        ILegatoManageBLWorker Get();
    }
}
