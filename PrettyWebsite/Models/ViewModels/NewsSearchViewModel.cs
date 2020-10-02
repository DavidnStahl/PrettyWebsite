using EPiServer.Find.UnifiedSearch;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels
{
    public class NewsSearchViewModel : PageViewModel<MoviePage>
    {
        public UnifiedSearchResults SearchResult { get; set; }

        public NewsSearchViewModel(MoviePage currentPage) : base(currentPage)
        {
        }
    }
}