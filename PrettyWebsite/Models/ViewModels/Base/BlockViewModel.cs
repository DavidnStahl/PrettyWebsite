using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Interfaces;

namespace PrettyWebsite.Models.ViewModels.Base
{
    public class BlockViewModel<T> : IBlockViewModel<T> where T : SiteBlockData
    {
        public BlockViewModel(T currentBlock)
        {
            CurrentBlock = currentBlock;
        }

        public T CurrentBlock { get; }
        public LayoutModel Layout { get; set; }
    }
}