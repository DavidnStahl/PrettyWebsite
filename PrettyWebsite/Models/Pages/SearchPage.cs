using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Geta.SEO.Sitemaps.Models;
using PrettyWebsite.Models.Blocks;

namespace PrettyWebsite.Models.Pages
{
    [ContentType(DisplayName = "SearchPage", GUID = "c9644445-8b91-4917-bd46-b1da7bf94885", Description = "")]

    
    public class SearchPage : SitePageData, IExcludeFromSitemap
    {
        
        [CultureSpecific]
        [Display(
            Name = "ReviewFormBlock container",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(new[] { typeof(ReviewFormBlock) })]
        public virtual ContentArea ReviewFormContentArea { get; set; }

        [CultureSpecific]
        [Display(
            Name = "MovieReviewBlock container",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [AllowedTypes(new[] { typeof(MovieReviewBlock) })]
        public virtual ContentArea MovieReviewContentArea { get; set; }

        [CultureSpecific]
        [Display(
            Name = "MovieDetails container",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [AllowedTypes(new[] { typeof(MovieDetailBlock) })]
        public virtual ContentArea MovieDetailsContentArea { get; set; }
    }
}