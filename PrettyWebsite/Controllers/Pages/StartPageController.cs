using System.Web.Mvc;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;
using PrettyWebsite.Models.ViewModels.Pages;
using PrettyWebsite.Services;

namespace PrettyWebsite.Controllers.Pages
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        private readonly IRssFeedService _rssFeedService;
        public StartPageController(IRssFeedService rssFeedService)
        {
            _rssFeedService = rssFeedService;
        }
        public ActionResult Index(StartPage currentPage)
        {
            var model = new StartPageViewModel(currentPage);
            model.RssFeed = _rssFeedService.Get();
            return View(model);
        }
    }
}