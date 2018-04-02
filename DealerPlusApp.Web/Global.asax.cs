using System.Data.Entity;
using DealerPlusApp.Data;
using DealerPlusApp.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DealerPlusApp.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutofacConfig.RegisterContainer(GlobalConfiguration.Configuration);
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfiguration.Configuration.EnsureInitialized();
            //Database.SetInitializer<DealerPlusEntities>(new DropCreateDatabaseIfModelChanges<DealerPlusEntities>());

        }
    }
}
