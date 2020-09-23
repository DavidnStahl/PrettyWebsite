using EPiServer.Find;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Interfaces;
using PrettyWebsite.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.Forms
{
    public class SearchFormModel : BaseFormModel<SearchFormBlock>
    {
        public string query { get; set; }

        public MovieSearch SearchResult { get; set; }

        public string SelectedType { get; set; }
    }
}