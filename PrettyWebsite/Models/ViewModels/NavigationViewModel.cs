using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.Containers;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Pages;

namespace PrettyWebsite.Models.ViewModels
{
    public class NavigationViewModel
    {
        public StartPage StartPage { get; set; }
        public Dictionary<CategoryNewsContainer,IEnumerable<SitePageData>> Menu { get; set; }
    }
}