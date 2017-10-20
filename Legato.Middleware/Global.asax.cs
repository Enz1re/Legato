using Ninject;
using Legato.BL;
using Ninject.Web.Common;
using Legato.ServiceContracts;


namespace Legato.Middleware
{
    public class WcfApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            MiddlewareMappings.CreateMappings();
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel(new LegatoMiddlewareDIModule());

            LegatoBLDI.Register(kernel);

            return kernel;
        }
    }
}
