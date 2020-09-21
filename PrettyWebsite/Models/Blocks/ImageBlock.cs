using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "Image Block", GUID = "7e578e5c-c9fd-48ca-9bcb-f557b7b18557", Description = "")]
    public class ImageBlock : SiteBlockData
    {
        [Display(Order = 10, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual Url Url { get; set; }
       
        [Display(Order = 20, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual string AltText { get; set; }     
        
    }
}