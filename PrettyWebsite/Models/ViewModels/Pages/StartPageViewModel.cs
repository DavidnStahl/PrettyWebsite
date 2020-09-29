using PrettyWebsite.DataStore;
using PrettyWebsite.Models.Forms;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrettyWebsite.Models.ViewModels.Pages
{
    public class StartPageViewModel : PageViewModel<StartPage>
    {       
        public StartPageViewModel(StartPage currentPage) : base(currentPage)
        {
        }
    }
}