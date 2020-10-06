using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "ImageCarouselBlock", GUID = "6cd3415f-b913-4d13-a7be-3a0226de6edc", Description = "")]
    public class ImageCarouselBlock : SiteBlockData
    {

        [Display(
        GroupName = SystemTabNames.Content,
        Name = "Images",
        Order = 10)]
        [AllowedTypes(typeof(ImageData))]
        public virtual IList<ContentReference> Images { get; set; }

    }
}