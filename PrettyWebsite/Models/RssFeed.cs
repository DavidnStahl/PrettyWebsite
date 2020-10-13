using System;

namespace PrettyWebsite.Models
{
    public class RssFeed
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Url { get; set; }
        public DateTimeOffset PublicationDate { get; set; }
        public string Category { get; set; }
    }
}