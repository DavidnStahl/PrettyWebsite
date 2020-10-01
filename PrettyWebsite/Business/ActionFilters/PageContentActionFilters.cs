using EPiServer.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrettyWebsite.Models.Blocks;
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

            if (viewModel is IPageViewModel<SitePageData> pageViewModel)
            {
                var currentContentLink = filterContext.RequestContext.GetContentLink();
                pageViewModel.Layout = pageViewModel.Layout ?? _contextFactory.CreateLayoutModel(currentContentLink, filterContext.RequestContext);
            }



            if (viewModel is IBlockViewModel<SiteBlockData> blockViewModel)
            {
                var currentContentLink = filterContext.RequestContext.GetContentLink();
                blockViewModel.Layout = blockViewModel.Layout ?? _contextFactory.CreateLayoutModel(currentContentLink, filterContext.RequestContext);
            }
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }
    }
}