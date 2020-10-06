using System.Collections.Generic;
using PrettyWebsite.Models.Pages;

namespace PrettyWebsite.Models.ViewModels
{
    public class LayoutModel
    {
        public StartPage StartPage { get; set; }

        public SitePageSettings PageSettings { get; set; }

        public IEnumerable<StartPage> StartPages { get; set; }
    }
}