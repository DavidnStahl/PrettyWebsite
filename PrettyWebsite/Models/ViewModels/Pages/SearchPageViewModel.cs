using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrettyWebsite.Models.ViewModels.Pages
{

    public class SearchPageViewModel : PageViewModel<SearchPage>
    {
        public MovieSearchViewModel MovieSearchViewModel { get; set; }

        //public NewsSearchViewModel NewsSearchViewModel { get; set; }

        //public IEnumerable<SelectListItem> SearchType { get; set; }

        public SearchPageViewModel(SearchPage currentPage) : base(currentPage)
        {
           
        }
    }
}