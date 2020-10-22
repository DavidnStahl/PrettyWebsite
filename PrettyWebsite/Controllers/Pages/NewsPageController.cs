using EPiServer.Web.Mvc;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;
using System.Web.Mvc;
using PrettyWebsite.Controllers.Base;

namespace PrettyWebsite.Controllers.Pages
{
    public class NewsPageController : PageControllerBase<NewsPage>
    {
        public ActionResult Index(NewsPage currentPage)
        {
            var model = new NewsPageViewModel(currentPage);

            return View(model);
        }
    }
}