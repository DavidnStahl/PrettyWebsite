using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.ServiceLocation;
using PrettyWebsite.Business.EditorDescriptors.ContentSelection;
using PrettyWebsite.Business.UIDescriptors.SettingIcons;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Validation;

namespace PrettyWebsite.Models.Pages
{
    [ContentType(DisplayName = "SitePageSettings", GUID = "EB3B22EE-9DA0-4384-82B0-CC8DD7E233B2", Description = "")]
    public class SitePageSettings : SitePageData, IUseSettingsIcon
    {


        [CultureSpecific]
        [Display(
            Name = "Header",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [Required]
        [ContentSelection(typeof(HeaderBlock))]
        public virtual ContentReference Header { get; set; }
           
        [CultureSpecific]
        [Display(
            Name = "Footer",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [Required]
        [ContentSelection(typeof(FooterBlock))]
        public virtual ContentReference Footer { get; set; }
    }
}