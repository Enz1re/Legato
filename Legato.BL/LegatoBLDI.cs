using Ninject;
using Legato.DAL;
using Legato.BL.Workers;
using Legato.BL.Interfaces;


namespace Legato.BL
{
    public static class LegatoBLDI
    {
        public static void Register(IKernel kernel)
        {
            LegatoDALDI.Register(kernel);
            kernel.Bind<ILegatoGuitarBLWorker>().To<LegatoGuitarBLWorker>();
            kernel.Bind<ILegatoManageBLWorker>().To<LegatoManageBLWorker>();
            kernel.Bind<ILegatoUserBLWorker>().To<LegatoUserBLWorker>();
        }
    }
}
