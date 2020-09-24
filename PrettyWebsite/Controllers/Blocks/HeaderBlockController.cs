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

            var startPage = _contentLoader.Get<StartPage>(startPageContentLink);
            var menu = _contentLoader.GetChildren<SitePageData>(startPage.ContentLink).Where(x => x.VisibleInMenu).ToList();
            menu.Insert(0, startPage);

            var model = new HeaderBlockViewModel(currentBlock)
            {
                Navigation = new NavigationViewModel
                {
                    Menu = menu                   
                }                  
            };

            return PartialView(model);
        }
    }
}
