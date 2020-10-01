using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Core.Internal;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiServer.Web.Mvc.Html;
using EPiServer.Web.Routing;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.Containers;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;
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
