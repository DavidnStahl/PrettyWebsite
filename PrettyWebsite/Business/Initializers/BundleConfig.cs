using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System.Web.Optimization;


namespace PrettyWebsite.Business.Initializers
{
    [InitializableModule]
    public class BundleConfig : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (context.HostType == HostType.WebApplication)
            {
                RegisterBundles(BundleTable.Bundles);
            }
        }

        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include(
                    "~/Static/js/bootstrap.js",
                    "~/Static/js/bootstrap.esm.js",
                    "~/Static/js/bootstrap.bundle.js"
                    ));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Static/css/bootstrap/*.css", new CssRewriteUrlTransform())
                .Include("~/Static/css/style.css", new CssRewriteUrlTransform()));
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}