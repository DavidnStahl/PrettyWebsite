using PrettyWebsite.DataStore;
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
        public string MovieId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Text")]
        public string Text { get; set; }
        [Display(Name = "Rating")]
        public double Rating { get; set; }
        public List<Review> ReviewDataList { get; set; }


        public MovieReviewBlockViewModel(MovieReviewBlock currentBlock) : base(currentBlock)
        {

        }
    }
}