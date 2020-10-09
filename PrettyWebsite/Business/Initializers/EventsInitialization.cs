using EPiServer;
using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using PrettyWebsite.Business.Constants;
using PrettyWebsite.Models.Pages;
using System;
using System.Threading;

namespace PrettyWebsite.Business.Initializers
{
    [InitializableModule]
    public class EventsInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var events = context.Locate.ContentEvents();
            events.CreatingContent += EventsCreatingContent;
            events.PublishingContent += PublishingContent;
        }

        public void Preload(string[] parameters)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        private void EventsCreatingContent(object sender, ContentEventArgs e)
        {
            var page = e.Content as SitePageData;

            if (page != null)
            {
                page.Robots = Indexing.IndexFollow;
            }
        }

        public void PublishingContent(object sender, ContentEventArgs e)
        {
            var content = e.Content as SitePageData;

            if (content != null)
            {
                content.XmlSitemapDate = DateTime.Now.ToString("d", Thread.CurrentThread.CurrentCulture);
            }
        }
    }
}