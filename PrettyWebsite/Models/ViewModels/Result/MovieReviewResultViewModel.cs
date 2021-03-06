﻿using PrettyWebsite.DataStore;
using System.Collections.Generic;

namespace PrettyWebsite.Models.ViewModels.Result
{
    public class MovieReviewResultViewModel
    {
        public List<Review> ReviewDataList { get; set; }

        public List<string> ReviewRatedList { get; set; }

    }
}