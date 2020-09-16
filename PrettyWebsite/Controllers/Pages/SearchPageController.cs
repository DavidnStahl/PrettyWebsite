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

            //model.SearchType = new List<SelectListItem>() {
            //         new SelectListItem { Text = "Movie By Title", Value = "1"},
            //         new SelectListItem { Text = "Articles And News", Value = "2" }
            //};

            if (string.IsNullOrWhiteSpace(query))
            {
                return View(model);
            }

            //Byt ut till selectListItem
            if (searchType == "1")
            {
                model.MovieSearchViewModel = new MovieSearchViewModel(currentPage);
                model.MovieSearchViewModel.SearchResult = await _movieRepository.SearchByTitle(query);

                return View(model);
            }
            else
            {
                // skapa model.NewsSearchViewModel
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