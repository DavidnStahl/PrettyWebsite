using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using EPiServer.Find.Cms;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;

namespace PrettyWebsite.Business
{
    public class PageViewContextFactory
    {
        private readonly IContentLoader _contentLoader;

        private readonly IContentRepository _contentRepository;

        public PageViewContextFactory(IContentLoader contentLoader, IContentRepository contentRepository)
        {
            _contentLoader = contentLoader;
            _contentRepository = contentRepository;
        }

        public virtual LayoutModel CreateLayoutModel(ContentReference currentContentLink, RequestContext requestContext)
        {
            return new LayoutModel
            {
                PageSettings = GetSitePageSettings(),
                StartPages = GetStartPages(),
                StartPage = _contentLoader.Get<StartPage>(SiteDefinition.Current.StartPage)
            };
        }

        private SitePageSettings GetSitePageSettings()
        {
            var settingsPage = new SitePageSettings();

            if (SiteDefinition.Current.StartPage == ContentReference.EmptyReference) return settingsPage;

            var settingsPages = _contentLoader.GetChildren<SitePageSettings>(SiteDefinition.Current.StartPage).ToList();

            if (settingsPages.Any())
            {
                settingsPage = settingsPages.FirstOrDefault();
            }

            return settingsPage;
        }

        private IEnumerable<StartPage> GetStartPages() => _contentRepository
                .GetChildren<StartPage>(SiteDefinition.Current.RootPage, new LoaderOptions { LanguageLoaderOption.MasterLanguage() });
    }
}