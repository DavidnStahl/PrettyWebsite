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

        [CultureSpecific]
        [Display(
                    Name = "SearchForm",
                    Description = "",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        [SelectOne(SelectionFactoryType = typeof(ContentSelectionFactory<SearchFormBlock>))]
        public virtual ContentReference SearchForm { get; set; }

    }
}