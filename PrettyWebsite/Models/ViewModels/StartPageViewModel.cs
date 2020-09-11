using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrettyWebsite.Models.Pages;

namespace PrettyWebsite.Models.ViewModels
{
    public class StartPageViewModel : PageViewModel<StartPage>
    {
        public StartPageViewModel(StartPage currentPage) : base(currentPage)
        {
        }
    }
}