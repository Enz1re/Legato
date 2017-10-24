using Ninject.Modules;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using Legato.DAL.Repositories;


namespace Legato.DAL.Tests
{
    public class LegatoTestDALDIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGuitarContext>().To<GuitarContext>()
                .WithConstructorArgument("connectionString", "TestConnection");
            Bind<IAcousticClassicalGuitarRepository>().To<AcousticClassicalGuitarRepository>();
            Bind<IAcousticWesternGuitarRepository>().To<AcousticWesternGuitarRepository>();
            Bind<IBassGuitarRepository>().To<BassGuitarRepository>();
            Bind<IElectricGuitarRepository>().To<ElectricGuitarRepository>();
            Bind<IRepositoryProvider>().To<RepositoryProvider>();
        }
    }
}
