using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.Containers;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;

namespace PrettyWebsite.Controllers.Blocks
{
    public class NewsBlockController : BlockController<NewsBlock>
    {
        private readonly IContentLoader _contentLoader;

        public NewsBlockController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public override ActionResult Index(NewsBlock currentBlock)
        {
            NewsContainer newsContainer = null;

            if (!ContentReference.IsNullOrEmpty(currentBlock.NewsContainer))
            {
                newsContainer = _contentLoader.Get<NewsContainer>(currentBlock.NewsContainer);
            }

            var model = new NewsViewModel
            {
                NewsList = _contentLoader.GetChildren<NewsPage>(newsContainer.ContentLink)
            };

            return PartialView(model);
        }
     
    }
}
