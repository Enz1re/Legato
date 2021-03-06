﻿using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using Legato.ServiceDAL;
using System.Web.Routing;
using System.Web.Optimization;
using Legato.Service.Workers;


namespace Legato.Service
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ServiceMappings.CreateMappings();
            GlobalConfiguration.Configuration.EnsureInitialized();

            (new TokenMonitorWorker()).Start();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, DELETE, OPTIONS");
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept, Origin, Authorization");
                HttpContext.Current.Response.End();
            }
        }
    }
}
