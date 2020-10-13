using PrettyWebsite.Models;
using System.Collections.Generic;

namespace PrettyWebsite.Services
{
    public interface IRssFeedService
    {
        List<RssFeed> Get();
    }
}
