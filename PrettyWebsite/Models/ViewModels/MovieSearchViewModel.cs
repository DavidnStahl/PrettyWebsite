using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using PrettyWebsite.Models;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;



namespace PrettyWebsite.Models.ViewModels
{
    public class MovieSearchViewModel : PageViewModel<SearchPage>
    {
        public MovieSearch SearchResult { get; set; }

        public MovieSearchViewModel(SearchPage currentPage) : base(currentPage)
        {
            
        }

    }
}