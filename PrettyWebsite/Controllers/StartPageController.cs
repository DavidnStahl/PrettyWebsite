using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;

namespace PrettyWebsite.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            var model = new StartPageViewModel(currentPage);

            return View(model);
        }
    }
}