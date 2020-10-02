using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using PrettyWebsite.Business.EditorDescriptors.ContentSelection;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "HeaderBlock", GUID = "4a009a73-e3cb-435c-b305-6dbd35eb4791", Description = "")]
    
    public class HeaderBlock : SiteBlockData
    {

        [Display(
            Name = "Search Form",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual SearchFormBlock SearchForm { get; set; }

    }
}