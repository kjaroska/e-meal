﻿using System.Web.Mvc;
using System.Web.Routing;
using emeal.App_Start;

namespace emeal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            UnityWebActivator.Start();
        }
    }
}
