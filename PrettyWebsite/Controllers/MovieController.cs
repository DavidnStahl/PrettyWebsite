using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Routing;
using PrettyWebsite.DataStore;
using PrettyWebsite.Models;
using PrettyWebsite.Models.Forms;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;
using PrettyWebsite.Repositories.Interfaces;

namespace PrettyWebsite.Controllers
{

    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IDataStoreRepository _dataStoreRepository;
        private readonly IContentLoader _contentLoader;
        private readonly IPageRouteHelper _pageRouteHelper;


        public MovieController(IMovieRepository movieRepository, IDataStoreRepository dataStoreRepository, IContentLoader contentLoader, IPageRouteHelper pageRouteHelper)
        {
            _movieRepository = movieRepository;
            _dataStoreRepository = dataStoreRepository;
            _contentLoader = contentLoader;
            _pageRouteHelper = pageRouteHelper;
        }

        [HttpGet]
        public async Task<ActionResult> Index(string id)
        {
            Session["movieId"] = id;
            var reviewList = _dataStoreRepository.Get(id);
            var movie = await _movieRepository.GetMovie(id).ConfigureAwait(false);

            var startPage = SiteDefinition.Current.StartPage == ContentReference.EmptyReference ? null : _contentLoader.Get<StartPage>(SiteDefinition.Current.StartPage);

            var model = new MovieViewModel(startPage)
            {
                Movie = movie,
                ReviewList = reviewList,
                Ratings = movie.Ratings.ToList()
            };

            if (reviewList.Any())
            {
                model.Ratings.Add(new Rating
                {
                    Source = "Prettywebsite",
                    Value = Math.Round(reviewList.Select(data => data.Rating).Average(), 1) + "/5.0"
                });
            }

            var x = Session["User"];

            var user = Session["User"] is User sessionUser
                ? sessionUser
                : new User
                {
                    MovieList = new List<string>(),
                    ReviewRatedList = new List<string>()
                };
            Session["User"] = user;

            model.MovieList = user.MovieList;

            return View(model);
        }


        [HttpPost]
        public virtual ActionResult Submit(ReviewFormModel formModel)
        {
            Session["movieId"] = formModel.Id;
            if (ModelState.IsValid)
            {
                var reviewData = new Review
                {
                    MovieId = Session["movieId"].ToString(),
                    Name = formModel.Author,
                    Text = formModel.Text,
                    Rating = Convert.ToDouble(formModel.Rating) == 0 ? 1 : Convert.ToDouble(formModel.Rating),
                    PublicationDate = DateTime.Now
                };

                _dataStoreRepository.Save(reviewData);

                AddToSession(formModel.Id);
            }

            return RedirectToAction(nameof(Index), new { id = formModel.Id });
        }

        public void AddToSession(string id)
        {

            var user = Session["User"] as User;
            user?.MovieList.Add(id);
        }
    }
}