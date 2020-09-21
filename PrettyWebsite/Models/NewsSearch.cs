using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models
{
    public class NewsSearch
    {
        public IEnumerable<News> Search { get; set; }
    }
}