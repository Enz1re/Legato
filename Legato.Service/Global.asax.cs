using System.Web.Mvc;
using System.Web.Http;
using Legato.ServiceDAL;
using System.Web.Routing;
using System.Web.Optimization;


namespace Legato.Service
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ServiceMappings.CreateMappings();
        }
    }
}
