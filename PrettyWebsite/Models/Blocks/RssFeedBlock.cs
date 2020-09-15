using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "RssFeedBlock", GUID = "f7c716fb-6484-4e15-982f-be9768ed70ef", Description = "")]
    public class RssFeedBlock : SiteBlockData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */
    }
}