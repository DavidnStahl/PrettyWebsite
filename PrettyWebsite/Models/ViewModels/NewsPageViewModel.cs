using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;

namespace PrettyWebsite.Models.ViewModels
{
    public class NewsPageViewModel : PageViewModel<NewsPage>
    {
        public NewsPageViewModel(NewsPage currentPage) : base(currentPage)
        {
        }
    }
}