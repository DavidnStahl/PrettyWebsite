using EPiServer.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Interfaces;

namespace PrettyWebsite.Business.ActionFilters
{
    public class PageContentActionFilters : IResultFilter
    {
        private readonly PageViewContextFactory _contextFactory;

        public PageContentActionFilters(PageViewContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var viewModel = filterContext.Controller.ViewData.Model;
            var model = viewModel as IPageViewModel<SitePageData>;

            if (model != null)
            {
                var currentContentLink = filterContext.RequestContext.GetContentLink();
                var layoutModel = model.Layout ?? _contextFactory.CreateLayoutModel(currentContentLink, filterContext.RequestContext);
                var layoutController = filterContext.Controller as IModifyLayout;

                if (layoutController != null)
                {
                    layoutController.ModifyLayout(layoutModel);
                }

                model.Layout = layoutModel;
            }
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }
    }
}