using PrettyWebsite.DataStore;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using PrettyWebsite.Models.ViewModels.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels.Pages
{
    public class MoviePageViewModel : PageViewModel<SearchPage>
    {
        public Movie Movie { get; }
        public List<Review> ReviewList { get; set; }
        
        public MoviePageViewModel(SearchPage currentPage,Movie movie, List<Review> reviewList) : base(currentPage)
        {
            Movie = movie;
            ReviewList = reviewList;
        }
    }
}