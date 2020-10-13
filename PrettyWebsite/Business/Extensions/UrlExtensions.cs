using EPiServer.Web.Routing;

namespace PrettyWebsite.Business.Extensions
{
    public static class UrlExtensions
    {
        public static string Url(this string url) => UrlResolver.Current.GetUrl(url);
    }
}