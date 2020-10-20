using System.IO;
using System.Linq;
using System.Reflection;
using EPiServer.Find.Cms;
using EPiServer.Find.Cms.Conventions;
using PrettyWebsite.Models;
using PrettyWebsite.Models.Pages;
using System.Web.Mvc;
using System.Web.Routing;
using EPiServer.PlugIn;
using PrettyWebsite.Helpers;

namespace PrettyWebsite
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            ContentIndexer.Instance.Conventions.ForInstancesOf<ImageFile>().ShouldIndex(x => false);
            ContentIndexer.Instance.Conventions.ForInstancesOf<SitePageSettings>().ShouldIndex(x => false);
            ContentIndexer.Instance.Conventions.ForInstancesOf<XmlSiteMapPage>().ShouldIndex(x => false);


            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }

        protected override void RegisterRoutes(RouteCollection routes)
        {
            base.RegisterRoutes(routes);
            routes.MapRoute("default", "{controller}/{action}", new { action = "index" });

            RegisterPluginControllers(routes);

        }

        protected void RegisterPluginControllers(RouteCollection routes)
        {
            var pluginControllers = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => typeof(Controller).IsAssignableFrom(type) && type.GetCustomAttributes(typeof(GuiPlugInAttribute),true).Any());

            foreach (var pluginController in pluginControllers)
            {
                routes.MapRoute(pluginController.ToControllerShortName().ToLower(), $"{pluginController.ToControllerShortName()}/"+"{action}", new { controller = pluginController.ToControllerShortName(), action = "Index" });
            }
        }
    }
}