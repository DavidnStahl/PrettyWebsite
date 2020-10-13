using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using PrettyWebsite.Business.Extensions;
using PrettyWebsite.Models.Interfaces;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Pages;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Pages
{
    public class XmlSiteMapPageController : PageController<XmlSiteMapPage>
    {
        private readonly IContentLoader _contentLoader;

        public XmlSiteMapPageController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }
        public ActionResult Index(XmlSiteMapPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            var model = new XmlSiteMapPageViewModel(currentPage)
            {
                StartPagesWithDescendants = GetStartPagesWithDescendants()
            };

            return View(model);
        }

        private Dictionary<StartPage, IEnumerable<SitePageData>> GetStartPagesWithDescendants()
        {
            var dictionary = new Dictionary<StartPage, IEnumerable<SitePageData>>();
            var startPages = _contentLoader.GetChildren<StartPage>(SiteDefinition.Current.RootPage, new LoaderOptions { LanguageLoaderOption.MasterLanguage() });

            foreach (var startPage in startPages)
            {
                var descendants = _contentLoader.GetDescendents(startPage.ContentLink).ToSitePageData().Where(p =>
                    !(p.Robots is null) && !p.Robots.ToLower().Contains("noindex") && !(p is IExcludeFromSiteMap));

                dictionary.Add(startPage, descendants);
            }

            return dictionary;
        }
    }
}