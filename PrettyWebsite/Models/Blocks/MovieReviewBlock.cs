using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "MovieReviewBlock", GUID = "ae520d7d-8c94-47b4-8f30-77cd9bcf8bd1", Description = "")]
    public class MovieReviewBlock : SiteBlockData
    {
        
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Title { get; set; }
    }
}