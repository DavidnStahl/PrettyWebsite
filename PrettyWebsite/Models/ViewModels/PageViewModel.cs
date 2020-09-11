using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Interfaces;

namespace PrettyWebsite.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public T CurrentPage { get; }
        public LayoutModel Layout { get; set; }
        public IContent Section { get; set; }

        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }
    }
}