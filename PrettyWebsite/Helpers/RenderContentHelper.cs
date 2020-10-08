using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc.Html;

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