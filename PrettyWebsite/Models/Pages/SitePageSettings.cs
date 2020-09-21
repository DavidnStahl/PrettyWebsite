using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
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
    }
}