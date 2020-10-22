using System.Collections.Generic;
using PrettyWebsite.Models;

namespace PrettyWebsite.Services.Interface
{
    public interface IRssFeedService
    {
        List<RssFeed> Get();
    }
}
