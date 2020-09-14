using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels.Pages
{

    public class SearchPageViewModel : PageViewModel<SearchPage>
    {
        
        public SearchPageViewModel(SearchPage currentPage) : base(currentPage)
        {
            
        }
    }
}