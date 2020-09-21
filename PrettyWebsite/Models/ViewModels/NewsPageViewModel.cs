using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels
{
    public class NewsPageViewModel : PageViewModel<NewsPage>
    {
        public NewsPageViewModel(NewsPage currentPage) : base(currentPage)
        {

        }
    }
}