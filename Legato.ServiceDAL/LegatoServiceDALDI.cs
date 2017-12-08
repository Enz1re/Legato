using Ninject;
using Legato.ServiceDAL.Interfaces;
using Legato.ServiceDAL.Middleware;
using Legato.ServiceDAL.Repositories;
using Legato.MiddlewareContracts.DataContracts;


namespace Legato.ServiceDAL
{
    public static class LegatoServiceDALDI
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<LegatoMiddlewareClient>().ToSelf();
            kernel.Bind<IGuitarRepository<AcousticClassicalGuitarDataModel>>().To<AcousticClassicalGuitarRepository>();
            kernel.Bind<IGuitarRepository<AcousticWesternGuitarDataModel>>().To<AcousticWesternGuitarRepository>();
            kernel.Bind<IGuitarRepository<BassGuitarDataModel>>().To<BassGuitarRepository>();
            kernel.Bind<IGuitarRepository<ElectricGuitarDataModel>>().To<ElectricGuitarRepository>();
        }
    }
}
