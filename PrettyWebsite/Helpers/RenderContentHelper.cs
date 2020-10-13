using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc.Html;
using System.Web.Mvc;

namespace PrettyWebsite.Helpers
{
    public static class RenderContentHelper
    {
        public static void RenderContent(this HtmlHelper html, ContentReference contentLink)

        {
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();

            if (contentLoader.TryGet<IContentData>(contentLink, out var contentData))
            {
                html.RenderContentData(contentData, false);
            }
        }
    }
}