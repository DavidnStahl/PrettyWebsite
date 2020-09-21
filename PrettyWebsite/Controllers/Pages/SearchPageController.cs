using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Find.UnifiedSearch;
using PrettyWebsite.DataStore;
using PrettyWebsite.Models;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;
using PrettyWebsite.Models.ViewModels.Pages;
using PrettyWebsite.Repositories.Interfaces;
using PrettyWebsite.Services;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Pages
{

    public class SearchPageController : PageControllerBase<SearchPage>
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IDataStoreRepository _dataStoreRepository;


        public SearchPageController(IMovieRepository movieRepository, IDataStoreRepository dataStoreRepository)
        {
            _movieRepository = movieRepository;
            _dataStoreRepository = dataStoreRepository;
        }

        public async Task<ActionResult> Index(SearchPage currentPage, string searchType, string query)
        {
            var model = new SearchPageViewModel(currentPage);


            if (string.IsNullOrWhiteSpace(query))
            {
                return View(model);
            }

            if (searchType == "1")
            {
                model.MovieSearchViewModel = new MovieSearchViewModel(currentPage);
                model.MovieSearchViewModel.SearchResult = await _movieRepository.SearchByTitle(query);

                return View(model);
            }
            else
            {
                model.NewsSearchViewModel = new NewsSearchViewModel(currentPage);

                var hitSpec = new HitSpecification
                {
                    ExcerptLength = 255
                };
                //lägg till sortering på sökresultat?
                var result = SearchClient.Instance.UnifiedSearchFor(query, Language.English).UsingSynonyms().ApplyBestBets();
                model.NewsSearchViewModel.SearchResult = result.Take(50).GetResult(hitSpec);

                return View(model);
            }
        }

        [HttpGet]
        public async Task<ActionResult> MovieDetails(SearchPage currentPage, string id, string name = null, string text = null, string rating = null)
        {
            //_dataStoreRepository.Delete(null);

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(rating))
            {

                Review reviewData = new Review
                {
                    MovieId = id,
                    Name = name,
                    Text = text,
                    Rating = double.Parse(rating),
                    PublicationDate = DateTime.Now
                };
                _dataStoreRepository.Save(reviewData);
            }
            var reviewList = _dataStoreRepository.Get(id);
            var movie = await _movieRepository.GetMovie(id);
            var model = new MovieViewModel(new SearchPage(), movie, reviewList);

            return View(model);
        }
    }
}