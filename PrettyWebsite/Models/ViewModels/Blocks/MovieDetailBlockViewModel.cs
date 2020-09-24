using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels.Blocks
{
    public class MovieDetailBlockViewModel : BlockViewModel<MovieDetailBlock>
    {
        public Movie Movie { get; set; }

        public List<Rating> Ratings { get; set; }
        public MovieDetailBlockViewModel(MovieDetailBlock currentBlock) : base(currentBlock)
        {

        }
    }
}