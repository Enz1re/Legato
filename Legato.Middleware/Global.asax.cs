using Ninject;
using Legato.BL;
using Ninject.Web.Common;
using Legato.BL.Interfaces;
using Legato.MiddlewareContracts;


namespace Legato.Middleware
{
    public class WcfApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            MiddlewareMappings.CreateMappings();
            new TokenMonitorWorker(CreateKernel().Get<ILegatoUserBLWorker>()).Start();
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel(new LegatoMiddlewareDIModule());

            LegatoBLDI.Register(kernel);

            return kernel;
        }
    }
}
