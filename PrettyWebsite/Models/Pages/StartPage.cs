using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using PrettyWebsite.Business.EditorDescriptors.ContentSelection;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.Containers;
using PrettyWebsite.Validation;

namespace PrettyWebsite.Models.Pages
{
    [ContentType(
        DisplayName = "StartPage",
        GUID = "2FE55D24-7A71-4F68-9012-63CBDD00DD80"
    )]
    [AvailableContentTypes(
        Availability.Specific, Include = new[] {typeof(SearchPage), typeof(SitePageSettings), typeof(NewsContainer) },
        ExcludeOn = new[] { typeof(StartPage)})
    ]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [SelectOne(SelectionFactoryType = typeof(ContentSelectionFactory<SitePageSettings>))]
        public virtual PageReference Settings { get; set; }

        [CultureSpecific]
        [Display(
            Name = "News container",
            GroupName = SystemTabNames.Content, 
            Order = 40)]
        public virtual ContentArea NewsArea { get; set; }

    }
}