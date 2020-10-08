using System.Collections.Generic;
using PrettyWebsite.Models.Containers;
using PrettyWebsite.Models.Pages;

namespace PrettyWebsite.Models.ViewModels
{
    public class NavigationViewModel
    {
        public StartPage StartPage { get; set; }
        public Dictionary<CategoryNewsContainer,IEnumerable<SitePageData>> Menu { get; set; }
    }
}