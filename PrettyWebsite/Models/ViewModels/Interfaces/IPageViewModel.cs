using EPiServer.Core;
using PrettyWebsite.Models.Pages;

namespace PrettyWebsite.Models.ViewModels.Interfaces
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; set; }
        IContent Section { get; set; }
    }
}