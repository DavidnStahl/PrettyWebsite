﻿using System.Collections.Concurrent;
using PrettyWebsite.Models;
using PrettyWebsite.Repositories.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace PrettyWebsite.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly string apiKey = "67ad42ac";


        public async Task<MovieSearch> SearchByTitle(string query)
        {
            var url = $"http://www.omdbapi.com/?s={query}&apikey={apiKey}";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url).ConfigureAwait(false);
                return response.IsSuccessStatusCode ? await response.Content.ReadAsAsync<MovieSearch>().ConfigureAwait(false) : null;
            }
        }

        public async Task<Movie> GetMovie(string id)
        {
            var url = $"http://www.omdbapi.com/?i={id}&apikey={apiKey}";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url).ConfigureAwait(false);
                return response.IsSuccessStatusCode ? await response.Content.ReadAsAsync<Movie>().ConfigureAwait(false) : null;
            }
        }

    }
}