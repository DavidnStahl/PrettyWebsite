using PrettyWebsite.Models.ViewModels;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Shell.Security;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Profile;
using EPiServer.Security;
using EPiServer.DataAbstraction;
using EPiServer.Personalization;

namespace PrettyWebsite.Controllers
{
    public class RegisterController : Controller
    {
        private static UIUserProvider UiUserProvider => ServiceLocator.Current.GetInstance<UIUserProvider>();

        private static UIRoleProvider UiRoleProvider => ServiceLocator.Current.GetInstance<UIRoleProvider>();

        private static UISignInManager UiSignInManager => ServiceLocator.Current.GetInstance<UISignInManager>();

        private const string AdminRoleName = "WebAdmins";
        private const string ErrorKey = "CreateError";

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Index(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var result = UiUserProvider.CreateUser(model.Username, model.Password, model.Email, null, null, true, out var status, out var errors);

            if (status == UIUserCreateStatus.Success)
            {
                UiRoleProvider.CreateRole(AdminRoleName);
                UiRoleProvider.AddUserToRoles(result.Username, new string[] { AdminRoleName });

                if (ProfileManager.Enabled)
                {
                    var profile = EPiServerProfile.Wrap(ProfileBase.Create(result.Username));
                    profile.Email = model.Email;
                    profile.Save();
                }

                AdministratorRegistrationPage.IsEnabled = false;
                SetFullAccessToWebAdmin();
                var resFromSignIn = UiSignInManager.SignIn(UiUserProvider.Name, model.Username, model.Password);
                if (resFromSignIn)
                {
                    return Redirect("/episerver/cms");
                }
            }
            AddErrors(errors);
            // If we got this far, something failed, redisplay form
            return View(model);
        }

        private static void SetFullAccessToWebAdmin()
        {
            var securityRep = ServiceLocator.Current.GetInstance<IContentSecurityRepository>();

            if (!(securityRep.Get(ContentReference.RootPage).CreateWritableClone() is IContentSecurityDescriptor permissions)) return;

            permissions.AddEntry(new AccessControlEntry(AdminRoleName, AccessLevel.FullAccess));
            securityRep.Save(ContentReference.RootPage, permissions, SecuritySaveType.Replace);
        }

        private void AddErrors(IEnumerable<string> errors)
        {
            foreach (var error in errors)
            {
                ModelState.AddModelError(ErrorKey, error);
            }
        }

        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (!AdministratorRegistrationPage.IsEnabled)
            {
                filterContext.Result = new HttpNotFoundResult();
                return;
            }
            base.OnAuthorization(filterContext);
        }

        
    }
}