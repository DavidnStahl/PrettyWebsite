using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System.Collections.Generic;

namespace PrettyWebsite.Models.ViewModels.Pages
{
    public class StartPageViewModel : PageViewModel<StartPage>
    {
        
        public StartPageViewModel(StartPage currentPage) : base(currentPage)
        {
        }
    }
}