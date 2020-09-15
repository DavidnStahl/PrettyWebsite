using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System.Collections.Generic;

namespace PrettyWebsite.Models.ViewModels.Pages
{
    public class StartPageViewModel : PageViewModel<StartPage>
    {
        public List<RssFeed> RssFeed { get; set; }
        public StartPageViewModel(StartPage currentPage) : base(currentPage)
        {
        }
    }
}