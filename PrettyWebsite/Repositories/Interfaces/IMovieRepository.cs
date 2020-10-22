using PrettyWebsite.Models;
using System.Threading.Tasks;

namespace PrettyWebsite.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        Task<MovieSearch> SearchByTitle(string query);
        Task<Movie> GetMovie(string id);
    }
}
