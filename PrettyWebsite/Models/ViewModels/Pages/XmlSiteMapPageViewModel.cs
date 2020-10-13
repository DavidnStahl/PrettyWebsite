using PrettyWebsite.Models.Interfaces;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System.Collections.Generic;

namespace PrettyWebsite.Models.ViewModels.Pages
{
    public class XmlSiteMapPageViewModel : PageViewModel<XmlSiteMapPage>, IExcludeFromSiteMap
    {
        public Dictionary<StartPage, IEnumerable<SitePageData>> StartPagesWithDescendants { get; set; }

        public XmlSiteMapPageViewModel(XmlSiteMapPage currentPage) : base(currentPage)
        {
        }
    }
}