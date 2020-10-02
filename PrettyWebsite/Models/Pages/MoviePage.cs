using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Geta.SEO.Sitemaps.Models;
using PrettyWebsite.Business.UIDescriptors.VideoIcon;
using PrettyWebsite.Models.Blocks;

namespace PrettyWebsite.Models.Pages
{
    [ContentType(DisplayName = "Movie Page", GUID = "35D26738-B0C7-4950-81EC-FA89FDE993F0", Description = "")]
    public class MoviePage : SitePageData, IExcludeFromSitemap, IUseVideoIcon
    {
        [Display(
            Name = "Movie Details",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual MovieDetailBlock MovieDetails { get; set; }

        [Display(
            Name = "Review Form",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual ReviewFormBlock ReviewForm { get; set; }

        [Display(
            Name = "Movie Review",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual MovieReviewBlock MovieReview { get; set; }

        
    }
}