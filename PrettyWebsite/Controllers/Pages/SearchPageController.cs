using PrettyWebsite.Models;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;
using PrettyWebsite.Models.ViewModels.Pages;
using PrettyWebsite.Repositories.Interfaces;
using PrettyWebsite.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Pages
{

    public class SearchPageController : PageControllerBase<SearchPage>
    {
        private readonly IMovieRepository _movieRepository;
     

        public SearchPageController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
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
                model.MovieSearchViewModel = new MovieSearchViewModel(currentPage) { Search = new MovieSearch() };
                model.MovieSearchViewModel.Search = await _movieRepository.SearchByTitle(query);

                return View(model);
            }
            else
            {
                // skapa model.NewsSearchViewModel
                return View(model);
            }
        }

        [HttpGet]
        public async Task<ActionResult> MovieDetails(MoviePage currentPage, string id)
        {
            var movie = await _movieRepository.GetMovie(id);
            var model = new MovieViewModel(currentPage, movie);

            return View(model);
        }

    }
}