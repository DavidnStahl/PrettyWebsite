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
using PrettyWebsite.Models.ViewModels.Blocks;

namespace PrettyWebsite.Controllers.Blocks
{
    public class HeaderBlockController : BlockController<HeaderBlock>
    {
        private readonly IContentLoader _contentLoader;

        public HeaderBlockController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }
        public override ActionResult Index(HeaderBlock currentBlock)
        {
            var startPageContentLink = SiteDefinition.Current.StartPage;

            var menu = new Dictionary<CategoryNewsContainer, IEnumerable<SitePageData>>();

            var startPage = _contentLoader.Get<StartPage>(startPageContentLink);
            var newsContainer = _contentLoader.GetChildren<NewsContainer>(startPage.ContentLink).FirstOrDefault(x => x.VisibleInMenu);

            if (newsContainer is NewsContainer container)
            {

                var categoryNewsContainers = _contentLoader
                    .GetChildren<CategoryNewsContainer>(container.ContentLink)
                    .Where(x => x.VisibleInMenu);

                foreach (var categoryContainer in categoryNewsContainers)
                {
                    menu.Add(
                        categoryContainer, 
                        _contentLoader.GetChildren<SitePageData>(categoryContainer.ContentLink).Where(x => x.VisibleInMenu)
                        );
                }
            }

            //var menu = _contentLoader.GetChildren<CategoryNewsContainer>(newsContainer.ContentLink).Where(x => x.VisibleInMenu).ToList();

            var model = new HeaderBlockViewModel(currentBlock)
            {
                Navigation = new NavigationViewModel
                {
                    StartPage = startPage,
                    Menu = menu                   
                }                  
            };

            return PartialView(model);
        }
    }
}
