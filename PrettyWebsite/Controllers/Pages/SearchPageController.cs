using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;
using PrettyWebsite.Models.ViewModels.Pages;
using PrettyWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Pages
{
    
    public class SearchPageController : PageControllerBase<SearchPage>
    {
        public ActionResult Index(SearchPage currentPage,string searchType, string query)
        {
            var y = searchType;
            var x = query;
            var model = new SearchPageViewModel(currentPage);
            

            return View(model);
        }

    }
}