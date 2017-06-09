using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Hackaton_app.Models;

namespace Hackaton_app
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // = = Upgrade the database
            //System.Data.Entity.Database.SetInitializer<DatabaseContent>(new MigrateDatabaseToLatestVersion<DatabaseContent, MyObjextContextMigration<DatabaseContent>>());
            //DatabaseContent contexttest = new DatabaseContent();
            //contexttest.Database.Initialize(true);
        }
    }
}
