using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Pages;

namespace PrettyWebsite.Controllers.Pages
{
    public class ArticlePageController : PageControllerBase<ArticlePage>
    {
        public ActionResult Index(ArticlePage currentPage)
        {
            var model = new ArticlePageViewModel(currentPage);

            return View(model);
        }
    }
}