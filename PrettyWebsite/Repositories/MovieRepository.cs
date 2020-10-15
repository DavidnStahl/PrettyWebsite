using System.Collections.Concurrent;
using PrettyWebsite.Models;
using PrettyWebsite.Repositories.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace PrettyWebsite.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly string apiKey = "67ad42ac";

        private readonly ConcurrentDictionary<string, Task<MovieSearch>> _movieSearchCache = new ConcurrentDictionary<string, Task<MovieSearch>>();
        private readonly ConcurrentDictionary<string, Task<Movie>> _movieCache = new ConcurrentDictionary<string, Task<Movie>>();

        public async Task<MovieSearch> SearchByTitle(string query)
        {
            var url = $"http://www.omdbapi.com/?s={query}&apikey={apiKey}";

            return await _movieSearchCache.GetOrAdd(query, x => HttpClientGet<MovieSearch>(url)).ConfigureAwait(false);
        }

        public async Task<Movie> GetMovie(string id)
        {
            var url = $"http://www.omdbapi.com/?i={id}&apikey={apiKey}";

            return await _movieCache.GetOrAdd(id, x => HttpClientGet<Movie>(url)).ConfigureAwait(false);
        }

        public async Task<T> HttpClientGet<T>(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url).ConfigureAwait(false);
                return response.IsSuccessStatusCode ? await response.Content.ReadAsAsync<T>().ConfigureAwait(false) : default;
            }
        }
    }
}