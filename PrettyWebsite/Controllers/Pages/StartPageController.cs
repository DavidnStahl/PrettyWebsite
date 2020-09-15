using System.Web.Mvc;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;
using PrettyWebsite.Models.ViewModels.Pages;
using PrettyWebsite.Services;

namespace PrettyWebsite.Controllers.Pages
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            var feed = new RssFeedService();
            var result = feed.Get();
            var model = new StartPageViewModel(currentPage);
            model.RssFeed = result;
            return View(model);
        }
    }
}