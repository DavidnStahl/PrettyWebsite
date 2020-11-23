using EPiServer.Personalization.VisitorGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace PrettyWebsite.Business.Personalization.LoggedIn
{
    [VisitorGroupCriterion(
         Category = "Technical",
         DisplayName = "Logged in",
         Description = "Checks if a logged in cookie exists"
     )]
    public class LoggedInCriterion : CriterionBase<LoggedInCriterionSettings>
    {
        public override bool IsMatch(IPrincipal principal, HttpContextBase httpContext)
        {
            return HttpContext.Current.User.Identity.IsAuthenticated;
        }
    }
}