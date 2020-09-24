using EPiServer;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using PrettyWebsite.Models.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Pages
{
    public class DefaultPageController : PageControllerBase<SitePageData>
    {
        public ViewResult Index(SitePageData currentPage)
        {
            var model = CreateModel(currentPage);
            return View(string.Format("~/Views/{0}/Index.cshtml", currentPage.GetOriginalType().Name), model);
        }

        private static IPageViewModel<SitePageData> CreateModel(SitePageData page)
        {
            var type = typeof(PageViewModel<>).MakeGenericType(page.GetOriginalType());
            return Activator.CreateInstance(type, page) as IPageViewModel<SitePageData>;
        }
    }
}