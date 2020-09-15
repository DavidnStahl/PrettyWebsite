﻿using System.Collections.Generic;

namespace PrettyWebsite.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }

        //Bellow: Only included when searching by id
        public string Runtime { get; set; }
        public string Released { get; set; }
        public string Genre { get; set; }
        public string Rated { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Writer { get; set; }
        public string Production { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Awards { get; set; }
        public string Metascore { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }
        public string BoxOffice { get; set; }

        public IEnumerable<Rating> Ratings { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Movie)) return false;
            var movie = (Movie)obj;
            return movie.Title == Title;
        }

        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }

    }
}