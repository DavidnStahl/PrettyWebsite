using PrettyWebsite.Models.Pages;
using System.Collections.Generic;

namespace PrettyWebsite.Models.ViewModels
{
    public class LayoutModel
    {
        public StartPage StartPage { get; set; }

        public SitePageSettings PageSettings { get; set; }

        public IEnumerable<StartPage> StartPages { get; set; }
    }
}