using PrettyWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyWebsite.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        Task<MovieSearch> SearchByTitle(string query);
        Task<Movie> GetMovie(string id);
    }
}
