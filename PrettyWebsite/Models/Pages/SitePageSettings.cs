using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using PrettyWebsite.Business.UIDescriptors.SettingIcons;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace PrettyWebsite.Models.Pages
{
    [ContentType(DisplayName = "SitePageSettings", GUID = "EB3B22EE-9DA0-4384-82B0-CC8DD7E233B2", Description = "")]
    public class SitePageSettings : SitePageData, IUseSettingsIcon, IExcludeFromSiteMap
    {
        [Display(
            Name = "Header",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual HeaderBlock Header { get; set; }

        [Display(
            Name = "Footer",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual FooterBlock Footer { get; set; }
    }
}