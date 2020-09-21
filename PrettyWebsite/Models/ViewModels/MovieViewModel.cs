using PrettyWebsite.DataStore;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels
{
    public class MovieViewModel : PageViewModel<SearchPage>
    {
        public Movie Movie { get; }

        public List<Review> ReviewList { get; set; }

        public MovieViewModel(SearchPage currentPage, Movie movie, List<Review> reviewList) : base(currentPage)
        {
            Movie = movie;
            ReviewList = reviewList;
        }
    }
}