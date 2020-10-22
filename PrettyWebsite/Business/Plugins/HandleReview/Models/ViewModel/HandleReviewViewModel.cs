using System.Collections.Generic;
using PrettyWebsite.DataStore;
using PrettyWebsite.Models;

namespace PrettyWebsite.Business.Plugins.HandleReview.Models.ViewModel
{
    public class HandleReviewViewModel
    {
        public Dictionary<Movie,List<Review>> Movies { get; set; }
    }
}