using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace PrettyWebsite.Models
{
    public class RssFeed
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Url { get; set; }
        public string PublicationDate { get; set; }
        public Collection<SyndicationCategory> Category { get; set; }
    }
}