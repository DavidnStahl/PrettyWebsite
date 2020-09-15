using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using EPiServer.Find.Helpers.Reflection;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Personalization;
using EPiServer.ServiceLocation;
using EPiServer.Shell.Security;

namespace PrettyWebsite.Business.Initializers
{
    //[InitializableModule]
    //[ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    //public class EpiserverInitialization : IInitializableModule
    //{
    //    public void Initialize(InitializationEngine context)
    //    {
    //        var users = ServiceLocator.Current.GetInstance<UIUserProvider>();
    //        var roles = ServiceLocator.Current.GetInstance<UIRoleProvider>();
    //        var user = users.GetUser("Admin");

    //        if (user == null)
    //        {
    //            user = users.CreateUser("Admin", "Password123!", "admin@prettywebsite.com", "Hur gammal är du?", "15", true, out var status, out var errors);
    //        }

    //        if (!roles.RoleExists("WebAdmins"))
    //        {
    //            roles.CreateRole("WebAdmins");
    //        }

    //        if (!roles.RoleExists("WebEditors"))
    //        {
    //            roles.CreateRole("WebEditors");
    //        }

    //        if (!roles.RoleExists("CmsAdmins"))
    //        {
    //            roles.CreateRole("CmsAdmins");
    //        }

    //        if (!roles.RoleExists("CmsEditors"))
    //        {
    //            roles.CreateRole("CmsEditors");
    //        }

    //        if (!roles.RoleExists("Administrators"))
    //        {
    //            roles.CreateRole("Administrators");
    //        }

    //        var userRoles = roles.GetAllRolesForUser(user.Username);
    //        if (userRoles.All(r=>r != "WebAdmins"))
    //        {
    //            roles.AddUserToRoles(user.Username, new[] { "WebAdmins" });
    //        }
    //        if (userRoles.All(r => r != "WebEditors"))
    //        {
    //            roles.AddUserToRoles(user.Username, new[] { "WebEditors" });
    //        }
    //        if (userRoles.All(r => r != "CmsAdmins"))
    //        {
    //            roles.AddUserToRoles(user.Username, new[] { "CmsAdmins" });
    //        }
    //        if (userRoles.All(r => r != "CmsEditors"))
    //        {
    //            roles.AddUserToRoles(user.Username, new[] { "CmsEditors" });
    //        }
    //        if (userRoles.All(r => r != "Administrators"))
    //        {
    //            roles.AddUserToRoles(user.Username, new[] { "Administrators" });
    //        }
    //    }

    //    public void Uninitialize(InitializationEngine context)
    //    {

    //    }
    //}
}