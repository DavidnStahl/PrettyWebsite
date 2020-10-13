using EPiServer.Web.Mvc;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;
using System.Web.Mvc;

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