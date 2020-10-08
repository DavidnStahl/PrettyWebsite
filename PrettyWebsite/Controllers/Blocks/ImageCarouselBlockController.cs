using System.Web.Mvc;
using EPiServer;
using EPiServer.Web.Mvc;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Blocks;

namespace PrettyWebsite.Controllers.Blocks
{
    public class ImageCarouselBlockController : BlockController<ImageCarouselBlock>
    {
        private readonly IContentLoader _contentLoader;

        public ImageCarouselBlockController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }
        public override ActionResult Index(ImageCarouselBlock currentBlock)
        {
            var model = new ImageCarouselBlockViewModel(currentBlock);
            return PartialView(model);
        }
    }
}
