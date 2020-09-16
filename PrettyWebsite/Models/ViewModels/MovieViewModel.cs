using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels
{
    //public class MovieViewModel : PageViewModel<MoviePage>
    public class MovieViewModel : PageViewModel<SearchPage>
    {
        public Movie Movie { get; }
            
        public MovieViewModel(SearchPage currentPage, Movie movie) : base(currentPage)
        {
            Movie = movie;
        }
    }
}