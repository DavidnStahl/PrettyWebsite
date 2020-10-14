using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using PrettyWebsite.Business.UIDescriptors.WebsiteIcons;

namespace PrettyWebsite.Models.Pages
{
    [ContentType(DisplayName = "XmlSiteMap", GUID = "f9c3bdec-35d5-43d4-95ae-6f608d82691a", Description = "")]
    public class XmlSiteMapPage : SitePageData, IUseWebsiteIcon
    {
    }
}