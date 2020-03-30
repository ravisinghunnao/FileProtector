using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication2
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        internal protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // Get objects.
            HttpContext context = base.Context;

            context.Request.Headers.Add("FileServerHeader", "a secure header");
            // Complete.
           
        }
    }
}