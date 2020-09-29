using EPiServer.Find.Cms;
using EPiServer.Find.Cms.Conventions;
using PrettyWebsite.Models.Pages;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace PrettyWebsite
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            ContentIndexer.Instance.Conventions.ForInstancesOf<SearchPage>().ShouldIndex(x => false);
            //ContentIndexer.Instance.Conventions.ForInstancesOf<StartPage>().ShouldIndex(x => false);
            ContentIndexer.Instance.Conventions.ForInstancesOf<SitePageSettings>().ShouldIndex(x => false);


            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }

        protected override void RegisterRoutes(RouteCollection routes)
        {
            base.RegisterRoutes(routes);
            routes.MapRoute("default","{controller}/{action}",new { action = "index" });
        }
    }
}