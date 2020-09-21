using PrettyWebsite.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels
{
    public class NewsViewModel
    {
        public IEnumerable<NewsPage> NewsList { get; set; }
    }
}