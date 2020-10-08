using System.Web.Mvc;
using EPiServer.Shell.Security;
using EPiServer.Web.Mvc;
using PrettyWebsite.Models.Pages;

namespace PrettyWebsite.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T>
        where T : SitePageData
    {
        protected EPiServer.ServiceLocation.Injected<UISignInManager> UISignInManager;

        public ActionResult Logout()
        {
            UISignInManager.Service.SignOut();

            return RedirectToAction("Index");
        }
    }
}