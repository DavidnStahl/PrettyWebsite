using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace PrettyWebsite.Models.Pages
{
    [ContentType(DisplayName = "ArticlePage", GUID = "0a33dd10-8222-4c53-a194-647a96664a08", Description = "")]
    public class ArticlePage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "News container",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentArea NewsArea { get; set; }
    }
}