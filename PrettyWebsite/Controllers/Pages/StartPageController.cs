using System;
using System.Globalization;
using System.Web.Mvc;
using PrettyWebsite.DataStore;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;
using PrettyWebsite.Models.ViewModels.Pages;
using PrettyWebsite.Repositories.Interfaces;
using PrettyWebsite.Services;

namespace PrettyWebsite.Controllers.Pages
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