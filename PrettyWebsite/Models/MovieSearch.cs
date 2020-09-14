using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models
{
    public class MovieSearch
    {
        public IEnumerable<Movie> SearchResult { get; set; }
    }
}