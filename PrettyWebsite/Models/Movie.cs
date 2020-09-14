using System.Collections.Generic;

namespace PrettyWebsite.Models
{
    public class Movie
    {
        public string Runtime { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string imdbID { get; set; }

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

        //övriga properties 
        //   Rated       ":"PG-13",
            //   Released    ":"16 Jul 2010"
        //   Writer      ":"Christopher Nolan"
            //   Language    ":"English, Japanese, French",
        //   Country     ":"USA, UK",
            //   Awards      ":"Won 4 Oscars. Another 152 wins & 217 nominations.",
            //   "Metascore":"74",
            //   "imdbRating":"8.8",
            //   "imdbVotes":"2,003,841"
            //   "Type":"movie",
        //   "DVD":"07 Dec 2010",
        //   "BoxOffice":"$292,568,851",
        //   "Production":"Warner Bros. Pictures",
        //   "Website":"N/A",
        //   "Response":"True"
        //}


    }
}