using Ninject;
using Legato.ServiceDAL;
using Legato.ServiceDAL.Interfaces;


namespace Legato.Service
{
    public class LegatoServiceDI
    {
        public static void Register(IKernel kernel)
        {
            LegatoServiceDALDI.Register(kernel);
            kernel.Bind<IGuitarUnitOfWork>().To<GuitarUnitOfWork>();
            kernel.Bind<ILegatoGuitarServiceWorker>().To<LegatoServiceWorker>();
            kernel.Bind<ILegatoManageServiceWorker>().To<LegatoManageServiceWorker>();
        }
    }
}
