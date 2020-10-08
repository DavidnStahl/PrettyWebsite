using PrettyWebsite.Models;
using System.Threading.Tasks;
using PrettyWebsite.Views;

namespace PrettyWebsite.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        Task<MovieSearch> SearchByTitle(string query);
        Task<Movie> GetMovie(string id);
    }
}
