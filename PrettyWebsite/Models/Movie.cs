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



//   Rated       ":"PG-13",
//   Released    ":"16 Jul 2010",
//   Runtime     ":"148 min",
//   Genre       ":"Action, Adventure, Sci-Fi, Thriller",
//   Director    ":"Christopher Nolan",
//   Writer      ":"Christopher Nolan",
//   Actors      ":"Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page, Tom Hardy",
//   Plot        ":"A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
//   Language    ":"English, Japanese, French",
//   Country     ":"USA, UK",
//   Awards      ":"Won 4 Oscars. Another 152 wins & 217 nominations.",
//   Poster      ":"https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SX300.jpg",
//   "Ratings":[
//      {
//         "Source":"Internet Movie Database",
//         "Value":"8.8/10"
//      },
//      {
//         "Source":"Rotten Tomatoes",
//         "Value":"87%"
//      },
//      {
//    "Source":"Metacritic",
//         "Value":"74/100"
//      }
//   ],
//   "Metascore":"74",
//   "imdbRating":"8.8",
//   "imdbVotes":"2,003,841",
//   "imdbID":"tt1375666",
//   "Type":"movie",
//   "DVD":"07 Dec 2010",
//   "BoxOffice":"$292,568,851",
//   "Production":"Warner Bros. Pictures",
//   "Website":"N/A",
//   "Response":"True"
//}


    }
}