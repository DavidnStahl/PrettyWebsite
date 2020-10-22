using System;
using PrettyWebsite.Models;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;
using EPiServer.Logging.Compatibility;
using PrettyWebsite.Services.Interface;
using StructureMap.Building;

namespace PrettyWebsite.Services
{
    public class RssFeedService : IRssFeedService
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(RssFeedService));

        public List<RssFeed> Get()
        {
            try
            {
                var rssFeedUrl = "https://www.metacritic.com/rss/movies";
                var reader = XmlReader.Create(rssFeedUrl);
                var feed = SyndicationFeed.Load(reader);

                var rssFeedList = feed.Items.Select(item => new RssFeed
                    {
                        Title = item.Title.Text,
                        Body = item.Summary.Text,
                        Url = item.Links[0].Uri.OriginalString,
                        PublicationDate = item.PublishDate,
                        Category = item.Categories[0].Name
                    })
                    .ToList();

                return rssFeedList.OrderByDescending(x => x.PublicationDate).Take(5).ToList();
            }
            catch (Exception e)
            {
                _log.Error(e.Message,e);
                return Enumerable.Empty<RssFeed>().ToList();
            }
        }
    }
}