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
            kernel.Bind<IAcousticClassicalGuitarRepository>().To<AcousticClassicalGuitarRepository>();
            kernel.Bind<IAcousticWesternGuitarRepository>().To<AcousticWesternGuitarRepository>();
            kernel.Bind<IBassGuitarRepository>().To<BassGuitarRepository>();
            kernel.Bind<IElectricGuitarRepository>().To<ElectricGuitarRepository>();
            kernel.Bind<IRepositoryProvider>().To<RepositoryProvider>();
        }
    }
}
