using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Pages
{
    
    public class SearchController : PageControllerBase<StartPage>
    {
        public ActionResult Index(StartPage currentPage, string query)
        {
            

            var model = new StartPageViewModel(currentPage);

            return View(model);
        }
    }
}