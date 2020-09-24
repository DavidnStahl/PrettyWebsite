using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "SearchFormBlock", GUID = "8a3ec8d4-a96b-49b4-bf74-595d7128ad59", Description = "")]
    public class SearchFormBlock : BlockData
    {
        
        [CultureSpecific]
        [Display(
            Name = "Search Type 1 text",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string SearchType1 { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Search Type 2 text",
                    Description = "",
                    GroupName = SystemTabNames.Content,
                    Order = 20)]
        public virtual string SearchType2 { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "placeholder text",
                    Description = "",
                    GroupName = SystemTabNames.Content,
                    Order = 30)]
        public virtual string placeholder { get; set; }

    }
}