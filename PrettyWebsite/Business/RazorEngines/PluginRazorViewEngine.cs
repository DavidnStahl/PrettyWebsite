using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Forms.Helpers.Internal;
using PrettyWebsite.Helpers;
using PrettyWebsite.Models.ViewModels.Interfaces;

namespace PrettyWebsite.Business.RazorEngines
{
    public class PluginRazorViewEngine : RazorViewEngine
    {
        public PluginRazorViewEngine()

        {
            PartialViewLocationFormats = new[]
            {
                "~/Business/Plugins/{1}/Views/{0}.cshtml",
                "~/Business/Plugins/Shared/{0}.cshtml"
            };

            ViewLocationFormats = new[]
            {
                "~/Business/Plugins/{1}/Views/{0}.cshtml"
            };
        }

        public override ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName,
            bool useCache)
        {
            if (controllerContext == null)
                throw new ArgumentNullException(nameof(controllerContext), "The controllerContext parameter is null");

            if (string.IsNullOrEmpty(partialViewName))
                throw new ArgumentException("The viewName parameter is null or empty.", nameof(partialViewName));

            if (controllerContext.Controller == null)
                return base.FindPartialView(controllerContext, partialViewName, useCache);

            var pluginName = controllerContext.Controller.ToControllerShortName();

            if (string.IsNullOrEmpty(pluginName))
                return base.FindPartialView(controllerContext, partialViewName, useCache);

            var cacheKey = $"{pluginName}|{partialViewName}";

            if (useCache && ViewLocationCache != null)
            {
                var cachedLocation = ViewLocationCache.GetViewLocation(controllerContext.HttpContext, cacheKey);
                if (!string.IsNullOrEmpty(cachedLocation))
                    return new ViewEngineResult(CreatePartialView(controllerContext, cachedLocation), this);
            }

            string trimmedViewName;
            if (partialViewName.EndsWith(".cshtml") || partialViewName.EndsWith(".vbhtml"))
                trimmedViewName = partialViewName.Remove(partialViewName.Length - 7);
            else
                trimmedViewName = partialViewName;
            var args = new object[] { trimmedViewName, pluginName };

            foreach (var location in PartialViewLocationFormats)
            {
                var path = string.Format(location, args);

                if (!FileExists(controllerContext, path)) continue;

                ViewLocationCache?.InsertViewLocation(controllerContext.HttpContext, cacheKey, path);
                return new ViewEngineResult(CreatePartialView(controllerContext, path), this);
            }
            return new ViewEngineResult(PartialViewLocationFormats.Select(i => string.Format(i, args)));
        }

        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName,
            string masterName, bool useCache)
        {
            viewName = viewName.ToTitleCaseString();

            if (controllerContext == null)
                throw new ArgumentNullException(nameof(controllerContext), "The controllerContext parameter is null");

            if (string.IsNullOrEmpty(viewName))
                throw new ArgumentException("The viewName parameter is null or empty.", nameof(viewName));

            if (controllerContext.Controller == null)
                return base.FindView(controllerContext, viewName, masterName, useCache);

            var pluginName = controllerContext.Controller.ToControllerShortName();
            if (string.IsNullOrEmpty(pluginName))
                return base.FindView(controllerContext, viewName, masterName, useCache);
            var cacheKey = $"{pluginName}|{viewName}";

            if (useCache && ViewLocationCache != null)
            {
                var cachedLocation = ViewLocationCache.GetViewLocation(controllerContext.HttpContext, cacheKey);
                if (!string.IsNullOrEmpty(cachedLocation))
                    return new ViewEngineResult(CreateView(controllerContext, cachedLocation, masterName),
                        this);
            }

            string trimmedViewName;
            if (viewName.EndsWith(".cshtml") || viewName.EndsWith(".vbhtml"))
                trimmedViewName = viewName.Remove(viewName.Length - 7);
            else
                trimmedViewName = viewName;
            var args = new object[] { trimmedViewName, pluginName };

            foreach (var location in ViewLocationFormats)
            {
                var path = string.Format(location, args);

                if (!FileExists(controllerContext, path)) continue;

                ViewLocationCache?.InsertViewLocation(controllerContext.HttpContext, cacheKey, path);

                return new ViewEngineResult(CreateView(controllerContext, path, masterName), this);
            }
            return new ViewEngineResult(ViewLocationFormats.Select(i => string.Format(i, args)));
        }
    }
}