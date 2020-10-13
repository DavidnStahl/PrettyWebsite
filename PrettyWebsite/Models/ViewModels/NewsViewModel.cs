using PrettyWebsite.Models.Pages;
using System.Collections.Generic;

namespace PrettyWebsite.Models.ViewModels
{
    public class NewsViewModel
    {
        public IEnumerable<NewsPage> NewsList { get; set; }
    }
}