using PrettyWebsite.Models.Containers;
using PrettyWebsite.Models.Pages;
using System.Collections.Generic;

namespace PrettyWebsite.Models.ViewModels
{
    public class NavigationViewModel
    {
        public StartPage StartPage { get; set; }
        public Dictionary<CategoryNewsContainer, IEnumerable<SitePageData>> Menu { get; set; }
    }
}