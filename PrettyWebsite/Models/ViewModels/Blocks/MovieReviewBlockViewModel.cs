﻿using PrettyWebsite.DataStore;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels.Blocks
{
    public class MovieReviewBlockViewModel : BlockViewModel<MovieReviewBlock>
    {        
        public List<Review> ReviewDataList { get; set; }

        public List<string> ReviewRatedList { get; set; }

        public string Id { get; set; }

        public string Rating { get; set; }
        public MovieReviewBlockViewModel(MovieReviewBlock currentBlock) : base(currentBlock)
        {

        }
    }
}