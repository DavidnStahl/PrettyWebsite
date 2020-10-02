using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using PrettyWebsite.Models;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using PrettyWebsite.Views;


namespace PrettyWebsite.Models.ViewModels
{
    public class MovieSearchViewModel : PageViewModel<MoviePage>
    {
        public MovieSearch SearchResult { get; set; }

        public MovieSearchViewModel(MoviePage currentPage) : base(currentPage)
        {
            
        }

    }
}