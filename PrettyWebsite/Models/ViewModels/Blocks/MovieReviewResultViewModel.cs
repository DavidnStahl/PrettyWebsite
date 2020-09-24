using PrettyWebsite.DataStore;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels.Blocks
{
    public class MovieReviewResultViewModel
    {
        public List<Review> ReviewDataList { get; set; }

        public List<string> ReviewRatedList { get; set; }

    }
}