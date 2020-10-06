using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Base;
using System.Collections.Generic;

namespace PrettyWebsite.Models.ViewModels.Blocks
{
    public class RssFeedBlockViewModel : BlockViewModel<RssFeedBlock>
    {
        public List<RssFeed> RssFeed { get; set; }
        public string Name { get; internal set; }

        public RssFeedBlockViewModel(RssFeedBlock currentBlock) : base(currentBlock)
        {

        }
    }
}