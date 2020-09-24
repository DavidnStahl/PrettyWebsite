using PrettyWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Views
{
    public class MovieSearch
    {
        public IEnumerable<Movie> Search { get; set; }
    }
}