using EPiServer.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Web;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using PrettyWebsite.Models.ViewModels.Interfaces;

namespace PrettyWebsite.Business.ActionFilters
{
    public class PageContentActionFilters : IResultFilter
    {
        private readonly PageViewContextFactory _contextFactory;
        private readonly IContentLoader _contentLoader;

        public PageContentActionFilters(PageViewContextFactory contextFactory, IContentLoader contentLoader)
        {
            _contextFactory = contextFactory;
            _contentLoader = contentLoader;
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var viewModel = filterContext.Controller.ViewData.Model;

            if (viewModel is IPageViewModel<SitePageData> pageViewModel)
            {
                var currentContentLink = filterContext.RequestContext.GetContentLink();
                pageViewModel.Layout = pageViewModel.Layout ?? _contextFactory.CreateLayoutModel(currentContentLink, filterContext.RequestContext);
            }
            else if (viewModel is IBlockViewModel<SiteBlockData> blockViewModel)
            {
                var currentContentLink = filterContext.RequestContext.GetContentLink();
                blockViewModel.Layout = blockViewModel.Layout ?? _contextFactory.CreateLayoutModel(currentContentLink, filterContext.RequestContext);
            }
            else
            {
                var startPage = _contentLoader.Get<StartPage>(SiteDefinition.Current.StartPage);
                viewModel = new PageViewModel<StartPage>(startPage)
                {
                    Layout = _contextFactory.CreateLayoutModel(startPage.ContentLink, filterContext.RequestContext)
                };
            }
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }
    }
}