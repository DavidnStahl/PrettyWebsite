using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;

namespace PrettyWebsite.Controllers.Pages
{
    public class ErrorController : PageControllerBase<SitePageData>
    {

        [BVNetwork.NotFound.Core.NotFoundPage.NotFoundPage]
        public ActionResult Error404()
        {
            return View();
        }
    }
}
