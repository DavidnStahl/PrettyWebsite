using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using PrettyWebsite.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace PrettyWebsite.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "3f3cf916-b627-4cf6-9aa3-91623ffbe38b", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,gif,bmp,png")]
    public class NewsPage : SitePageData
    {
        [Display(
          GroupName = SystemTabNames.Content,
          Order = 10
      )]
        public virtual ImageBlock Image { get; set; }


        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30
        )]
        [Searchable]
        [Required]
        public virtual string Headline { get; set; }

        [CultureSpecific]
        [Display(
          GroupName = SystemTabNames.Content,
          Order = 40
      )]
        [Searchable]
        [Required]
        public virtual XhtmlString Text { get; set; }

    }
}