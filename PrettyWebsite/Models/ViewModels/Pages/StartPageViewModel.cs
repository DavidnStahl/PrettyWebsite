using PrettyWebsite.DataStore;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrettyWebsite.Models.ViewModels.Pages
{
    public class StartPageViewModel : PageViewModel<StartPage>
    {
        public string MovieId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Text")]
        public string Text { get; set; }
        [Display(Name = "Rating")]
        public double Rating { get; set; }
        public List<Review> ReviewDataList { get; set; }
        public StartPageViewModel(StartPage currentPage) : base(currentPage)
        {
        }
    }
}