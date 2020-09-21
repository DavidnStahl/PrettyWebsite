using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models
{
    public class News
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Headline { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public DateTimeOffset PublicationDate { get; set; }

    }
}