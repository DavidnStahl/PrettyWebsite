using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "ReviewFormBlock", GUID = "ee99f934-97be-4b00-a088-24787a2b0073", Description = "")]
    public class ReviewFormBlock : BlockData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Title",
                    Description = "Title of the form",
                    GroupName = SystemTabNames.Content,
                    Order = 10)]
                public virtual string Title { get; set; }
         
    }
}