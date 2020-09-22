using System;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Find.Blocks.Models;
using EPiServer.SpecializedProperties;
using PrettyWebsite.Models.Blocks;

namespace PrettyWebsite.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "3f3cf916-b627-4cf6-9aa3-91623ffbe38b", Description = "")]
    public class NewsPage : SitePageData
    {
        [Display(
          GroupName = SystemTabNames.Content,
          Order = 10
      )]
        public virtual ImageBlock Image { get; set; }

        //[Display(
        //    GroupName = SystemTabNames.Content,
        //    Order = 10)]
        //[UIHint(UIHint.Image)]
        //public virtual ContentReference PageImage { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        [Required]
        //[ScaffoldColumn(false)]
        public virtual DateTime PublicationDate { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30
        )]
        [Required]
        public virtual string Headline { get; set; }

        [CultureSpecific]
        [Display(
          GroupName = SystemTabNames.Content,
          Order = 40
      )]
        [Required]
        public virtual XhtmlString Text { get; set; }

    }
}