using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Base;

namespace PrettyWebsite.Models.ViewModels.Blocks
{
    public class FooterBlockViewModel : BlockViewModel<FooterBlock>
    {
        public FooterBlockViewModel(FooterBlock currentBlock) : base(currentBlock)
        {
        }
    }
}