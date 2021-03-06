﻿using Ninject;
using Legato.DAL.Models;
using Legato.DAL.Interfaces;
using Legato.DAL.Repositories;


namespace Legato.DAL
{
    public static class LegatoDALDI
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<ILegatoContext>().To<LegatoContext>()
                .WithConstructorArgument("connectionString", Constants.Constants.DefaultConnectionStringName);
            kernel.Bind<IGuitarRepository<AcousticClassicalGuitarModel>>().To<AcousticClassicalGuitarRepository>();
            kernel.Bind<IGuitarRepository<AcousticWesternGuitarModel>>().To<AcousticWesternGuitarRepository>();
            kernel.Bind<IGuitarRepository<BassGuitarModel>>().To<BassGuitarRepository>();
            kernel.Bind<IGuitarRepository<ElectricGuitarModel>>().To<ElectricGuitarRepository>();
            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<IRepositoryProvider>().To<RepositoryProvider>();
        }
    }
}
