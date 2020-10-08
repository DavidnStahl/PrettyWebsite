using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "RssFeedBlock", GUID = "f7c716fb-6484-4e15-982f-be9768ed70ef", Description = "")]
    public class RssFeedBlock : SiteBlockData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Title",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Title { get; set; }
         
    }
}