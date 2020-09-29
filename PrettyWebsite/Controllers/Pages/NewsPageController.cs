using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;

namespace PrettyWebsite.Controllers.Pages
{
    public class NewsPageController : PageController<NewsPage>
    {
        public ActionResult Index(NewsPage currentPage)
        {
            var model = new NewsPageViewModel(currentPage);

            return View(model);
        }
    }
}