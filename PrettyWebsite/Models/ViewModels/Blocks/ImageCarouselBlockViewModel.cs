using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels.Blocks
{
    public class ImageCarouselBlockViewModel : BlockViewModel<ImageCarouselBlock>
    {
        public ImageCarouselBlockViewModel(ImageCarouselBlock currentBlock) : base(currentBlock)
        {
        }
    }
}