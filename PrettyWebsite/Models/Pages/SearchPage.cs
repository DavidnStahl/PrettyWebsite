using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using PrettyWebsite.Models.Blocks;

namespace PrettyWebsite.Models.Pages
{
    [ContentType(DisplayName = "SearchPage", GUID = "c9644445-8b91-4917-bd46-b1da7bf94885", Description = "")]

    
    public class SearchPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Review container",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentArea ContentArea { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Review2 container",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual ContentArea ContentArea2 { get; set; }
    }
}