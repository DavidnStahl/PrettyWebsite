using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "Image Block", GUID = "7e578e5c-c9fd-48ca-9bcb-f557b7b18557", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,gif,bmp,png")]
    public class ImageBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
          GroupName = SystemTabNames.Content,
          Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference PageImage { get; set; }

        [Display(Order = 20, GroupName = SystemTabNames.Content)]
        [StringLength(150)]
        public virtual string AltText { get; set; }     
        
    }
}