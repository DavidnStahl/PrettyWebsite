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
        //private readonly UrlResolver _urlResolver;
        //private readonly IDatabaseMode _databaseMode;

        public PageViewContextFactory(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
            //_urlResolver = urlResolver;
            //_databaseMode = databaseMode;
        }

        public virtual LayoutModel CreateLayoutModel(ContentReference currentContentLink, RequestContext requestContext)
        {
            var startPageContentLink = SiteDefinition.Current.StartPage;

            // Use the content link with version information when editing the startpage,
            // otherwise the published version will be used when rendering the props below.
            if (currentContentLink.CompareToIgnoreWorkID(startPageContentLink))
            {
                startPageContentLink = currentContentLink;
            }

            var startPage = _contentLoader.Get<StartPage>(startPageContentLink);

            var pageSettings = _contentLoader.Get<SitePageSettings>(startPage.Settings);


            return new LayoutModel
            {
                PageSettings = pageSettings,
                //Logotype = startPage.SiteLogotype,
                //LogotypeLinkUrl = new MvcHtmlString(_urlResolver.GetUrl(SiteDefinition.Current.StartPage)),
                //ProductPages = startPage.ProductPageLinks,
                //CompanyInformationPages = startPage.CompanyInformationPageLinks,
                //NewsPages = startPage.NewsPageLinks,
                //CustomerZonePages = startPage.CustomerZonePageLinks,
                //LoggedIn = requestContext.HttpContext.User.Identity.IsAuthenticated,
                //LoginUrl = new MvcHtmlString(GetLoginUrl(currentContentLink)),
                //SearchActionUrl = new MvcHtmlString(EPiServer.Web.Routing.UrlResolver.Current.GetUrl(startPage.SearchPageLink)),
                //IsInReadonlyMode = _databaseMode.DatabaseMode == DatabaseMode.ReadOnly
            };
        }

        private SitePageSettings GetSitePageSettings()
        {
            var settingsPage = new SitePageSettings();

            if (SiteDefinition.Current.StartPage != ContentReference.EmptyReference)
            {
                var settingsPages = _contentLoader.GetChildren<SitePageSettings>(SiteDefinition.Current.StartPage);

                if (settingsPages.Any())
                {
                    settingsPage = settingsPages.FirstOrDefault();
                }
            }

            return settingsPage;
        }

        //private string GetLoginUrl(ContentReference returnToContentLink)
        //{
        //    return string.Format(
        //        "{0}?ReturnUrl={1}",
        //        (FormsAuthentication.IsEnabled ? FormsAuthentication.LoginUrl : VirtualPathUtility.ToAbsolute(Global.AppRelativeLoginPath)),
        //        _urlResolver.GetUrl(returnToContentLink));
        //}

        //public virtual IContent GetSection(ContentReference contentLink)
        //{
        //    var currentContent = _contentLoader.Get<IContent>(contentLink);
        //    if (currentContent.ParentLink != null && currentContent.ParentLink.CompareToIgnoreWorkID(SiteDefinition.Current.StartPage))
        //    {
        //        return currentContent;
        //    }

        //    return _contentLoader.GetAncestors(contentLink)
        //        .OfType<PageData>()
        //        .SkipWhile(x => x.ParentLink == null || !x.ParentLink.CompareToIgnoreWorkID(SiteDefinition.Current.StartPage))
        //        .FirstOrDefault();
        //}
    }
}