using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Base;

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