using Ninject;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using Legato.DAL.Repositories;


namespace Legato.DAL
{
    public static class LegatoDALDI
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<IGuitarContext>().To<GuitarContext>()
                .WithConstructorArgument("connectionString", "DumbshitConnection");
            kernel.Bind<IGuitarRepository<AcousticClassicalGuitarModel>>().To<AcousticClassicalGuitarRepository>();
            kernel.Bind<IGuitarRepository<AcousticWesternGuitarModel>>().To<AcousticWesternGuitarRepository>();
            kernel.Bind<IGuitarRepository<BassGuitarModel>>().To<BassGuitarRepository>();
            kernel.Bind<IGuitarRepository<ElectricGuitarModel>>().To<ElectricGuitarRepository>();
            kernel.Bind<IRepositoryProvider>().To<RepositoryProvider>();
        }
    }
}
