using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Base;
using PrettyWebsite.Models.ViewModels.Interfaces;

namespace PrettyWebsite.Models.ViewModels.Blocks
{
    public class HeaderBlockViewModel : BlockViewModel<HeaderBlock>
    {
        public NavigationViewModel Navigation { get; set; }
        public HeaderBlockViewModel(HeaderBlock currentBlock) : base(currentBlock)
        {
        }
    }
}