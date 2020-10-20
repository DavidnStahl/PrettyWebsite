using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrettyWebsite.Helpers
{
    public static class StringHelper
    {
        public static string ToControllerShortName(this Controller controller) =>
            controller.GetType().Name.Replace("Controller", "");
        public static string ToControllerShortName(this ControllerBase controller) =>
            controller.GetType().Name.Replace("Controller", "");
        public static string ToControllerShortName(this string controllerFullname) =>
            controllerFullname.Replace("Controller", "");
        public static string ToControllerShortName(this Type controllerType) =>
            controllerType.GetType().Name.Replace("Controller", "");
    }
}