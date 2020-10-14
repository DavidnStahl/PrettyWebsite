using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using PrettyWebsite.Models.Pages;
using System.Collections.Generic;

namespace PrettyWebsite.Business.Extensions
{
    public static class ContentReferenceExtensions
    {
        private static readonly IContentLoader ContentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();

        public static IEnumerable<SitePageData> ToSitePageData(this IEnumerable<ContentReference> contentReferences)
        {
            foreach (var contentReference in contentReferences)
            {
                yield return contentReference.ToSitePageData();
            }
        }

        public static SitePageData ToSitePageData(this ContentReference contentReference) => ContentLoader.Get<SitePageData>(contentReference);
    }
}