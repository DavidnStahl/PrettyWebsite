using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Forms.Core.Models;
using EPiServer.Forms.Implementation.Elements;
using PrettyWebsite.Validation;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "FooterBlock", GUID = "0c5c18c6-bc20-4cb0-b36b-329e17b5877c", Description = "")]
    public class FooterBlock : SiteBlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Form",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [MaxItems(1)]
        [AllowedTypes(typeof(FormContainerBlock))]
        public virtual ContentArea Form { get; set; }

    }
}