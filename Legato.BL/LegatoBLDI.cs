using Ninject;
using Legato.DAL;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;


namespace Legato.BL
{
    public static class LegatoBLDI
    {
        public static void Register(IKernel kernel)
        {
            LegatoDALDI.Register(kernel);
            kernel.Bind<ILegatoGuitarBLWorker>().To<LegatoBusinessLayerWorker>();
            kernel.Bind<ILegatoManageBLWorker>().To<LegatoManageBLWorker>();
            kernel.Bind<IGuitarUnitOfWork>().To<GuitarUnitOfWork>();
        }
    }
}
