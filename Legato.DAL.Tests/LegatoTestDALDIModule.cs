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
            Bind<ILegatoContext>().To<LegatoContext>()
                .WithConstructorArgument("connectionString", "TestConnection");
            Bind<IGuitarRepository<AcousticClassicalGuitarModel>>().To<AcousticClassicalGuitarRepository>();
            Bind<IGuitarRepository<AcousticWesternGuitarModel>>().To<AcousticWesternGuitarRepository>();
            Bind<IGuitarRepository<BassGuitarModel>>().To<BassGuitarRepository>();
            Bind<IGuitarRepository<ElectricGuitarModel>>().To<ElectricGuitarRepository>();
            Bind<IRepositoryProvider>().To<RepositoryProvider>();
        }
    }
}
