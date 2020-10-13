using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Routing;
using System.Text;

namespace PrettyWebsite.Business.Extensions
{
    public static class IContentExtensions
    {
        public static string GetExternalUrl(this IContent content)
        {
            var internalUrl = UrlResolver.Current.GetUrl(content.ContentLink);

            if (internalUrl == null) return null;

            var url = new UrlBuilder(internalUrl);
            EPiServer.Global.UrlRewriteProvider.ConvertToExternal(url, null, Encoding.UTF8);
            var friendlyUrl = UriSupport.AbsoluteUrlBySettings(url.ToString());

            return friendlyUrl;
        }
    }
}