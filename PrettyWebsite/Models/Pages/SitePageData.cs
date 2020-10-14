using EPiServer.Core;
using EPiServer.DataAbstraction;
using System.ComponentModel.DataAnnotations;

namespace PrettyWebsite.Models.Pages
{
    public class SitePageData : PageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [UIHint("Robots")]
        public virtual string Robots { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 220
        )]
        [ScaffoldColumn(false)]
        public virtual string XmlSitemapDate { get; set; }
    }
}