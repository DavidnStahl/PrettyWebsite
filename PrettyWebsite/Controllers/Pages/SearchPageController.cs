using Castle.MicroKernel;
using EPiServer.Data;
using EPiServer.Web.Routing;
using PrettyWebsite.DataStore;
using PrettyWebsite.Models;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;
using PrettyWebsite.Models.ViewModels.Pages;
using PrettyWebsite.Repositories.Interfaces;
using PrettyWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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
       
        [HttpGet]
        public async Task<ActionResult> MovieDetails(SearchPage currentPage, string id)
        {
            Session["movieId"] = id;
            var reviewList = _dataStoreRepository.Get(id);
            var movie = await _movieRepository.GetMovie(id);

            var model = new MoviePageViewModel(currentPage, movie, reviewList);
            model.Ratings = movie.Ratings.ToList();
            if (reviewList.Count > 0)
            {
                model.Ratings.Add(new Rating
                {
                    Source = "Prettywebsite",
                    Value = Math.Round(reviewList.Select(data => data.Rating).Average(),1) + "/5.0"
                });
            }

            if(Session["User"] == null)
            {
                Session["User"] = new User
                {
                    MovieList = new List<string>(),
                    ReviewRatedList = new List<string>()
                };
            }

            var user = Session["User"] as User;

            model.movieList = user.MovieList;
            model.reviewRatedList = user.ReviewRatedList;

            return View(model);
        }

        [HttpGet]
        public ActionResult ReviewRating(SearchPage currentPage,string id, string rating,string movieId)
        {
            Identity.TryParse(id, out Identity identity);

            _dataStoreRepository.SaveRating(identity, rating);

            var user = Session["User"] as User;
            user.ReviewRatedList.Add(id);

            return RedirectToAction("MovieDetails",new { id = movieId });
        }

    }
}