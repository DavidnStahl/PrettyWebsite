using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "Block: News", GUID = "48c12aed-94e0-40bd-a372-78d3cd1939f5", Description = "")]
    public class NewsBlock : SiteBlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [Required]
        public virtual PageReference NewsContainer { get; set; }

    }
}