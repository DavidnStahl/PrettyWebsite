using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Base;

namespace PrettyWebsite.Models.ViewModels.Blocks
{
    public class ImageCarouselBlockViewModel : BlockViewModel<ImageCarouselBlock>
    {
        public ImageCarouselBlockViewModel(ImageCarouselBlock currentBlock) : base(currentBlock)
        {
        }
    }
}