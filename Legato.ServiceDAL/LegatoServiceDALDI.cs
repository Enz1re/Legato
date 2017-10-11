using Ninject;
using Legato.Middleware;
using Legato.MiddlewareContracts;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.Repositories;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL
{
    public static class LegatoServiceDALDI
    {
        public static void Register(IKernel kernel)
        {
            LegatoMiddlewareDI.Register(kernel);
            kernel.Bind<ILegatoMiddleware>().To<LegatoMiddleware>();
            kernel.Bind<IGuitarRepository<GuitarDataModel>>().To<GuitarRepository>();
            kernel.Bind<IGuitarRepository<AcousticClassicalGuitarDataModel>>().To<AcousticClassicalGuitarRepository>();
            kernel.Bind<IGuitarRepository<AcousticWesternGuitarDataModel>>().To<AcousticWesternGuitarRepository>();
            kernel.Bind<IGuitarRepository<BassGuitarDataModel>>().To<BassGuitarRepository>();
            kernel.Bind<IGuitarRepository<ElectroGuitarDataModel>>().To<ElectroGuitarRepository>();
            kernel.Bind<IServiceRepositoryProvider>().To<RepositoryProvider>();
        }
    }
}
