using PrettyWebsite.DataStore;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels
{
    public class MovieViewModel : PageViewModel<StartPage>
    {
        public Movie Movie { get; set; }
        public List<Review> ReviewList { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<string> MovieList { get; set; }

        public MovieViewModel(StartPage currentPage) : base(currentPage)
        {
        }
    }
}