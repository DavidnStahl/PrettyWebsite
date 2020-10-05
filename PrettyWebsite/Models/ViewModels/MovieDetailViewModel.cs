using System.Collections.Generic;

namespace PrettyWebsite.Models.ViewModels
{
    public class MovieDetailViewModel 
    {
        public Movie Movie { get; set; }

        public List<Rating> Ratings { get; set; }
    }
}