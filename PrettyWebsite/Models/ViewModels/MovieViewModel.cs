using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels
{
    public class MovieViewModel : PageViewModel<MoviePage>
    {
        public Movie Movie { get; }
            
        public MovieViewModel(MoviePage currentPage, Movie movie) : base(currentPage)
        {
            Movie = movie;
        }
    }
}