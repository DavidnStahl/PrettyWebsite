using PrettyWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Xml;

namespace PrettyWebsite.Services
{
    public class RssFeedService : IRssFeedService
    {
        public List<RssFeed> Get()
        {
            var rssFeedUrl = "https://www.metacritic.com/rss/movies";
            var reader = XmlReader.Create(rssFeedUrl);
            var feed = SyndicationFeed.Load(reader);

            List<RssFeed> rssFeedList = new List<RssFeed>();

            foreach (var item in feed.Items)
            {
                RssFeed rssFeed = new RssFeed
                {
                    Title = item.Title.Text,
                    Body = item.Summary.Text,
                    Url = item.Links[0].Uri.OriginalString,
                    PublicationDate = item.PublishDate.ToString(),
                    Category = item.Categories
                };

                rssFeedList.Add(rssFeed);                
            }

            return rssFeedList;
        }
    }
}