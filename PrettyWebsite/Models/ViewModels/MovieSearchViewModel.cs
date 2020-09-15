using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;

namespace PrettyWebsite.Models.ViewModels
{
    public class MovieSearchViewModel : PageViewModel<SearchPage>
    {
        public MovieSearch Search { get; set; }

        public MovieSearchViewModel(SearchPage currentPage) : base(currentPage)
        {
        }

    }
}