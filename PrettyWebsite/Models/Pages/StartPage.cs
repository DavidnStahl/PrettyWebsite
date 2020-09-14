using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Validation;

namespace PrettyWebsite.Models.Pages
{
    [ContentType(
        DisplayName = "StartPage",
        GUID = "2FE55D24-7A71-4F68-9012-63CBDD00DD80"
    )]
    [AvailableContentTypes(
        Availability.Specific,
        ExcludeOn = new[] { typeof(StartPage)})
    ]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(typeof(HeaderBlock))]
        [MaxItems(1)]
        [Required]
        public virtual ContentArea Header { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [AllowedTypes(typeof(FooterBlock))]
        [MaxItems(1)]
        [Required]
        public virtual ContentArea Footer { get; set; }

        [CultureSpecific]
        [Display(
            Name = "News container",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual ContentArea ContentArea { get; set; }

    }
}