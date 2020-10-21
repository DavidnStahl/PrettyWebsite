using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EPiServer.Data;
using EPiServer.PlugIn;
using PrettyWebsite.Business.Plugins.HandleReview.Models.ViewModel;
using PrettyWebsite.Repositories.Interfaces;

namespace PrettyWebsite.Business.Plugins.HandleReview.Controllers
{
    [GuiPlugIn(
        Area = PlugInArea.AdminMenu,
        Url = "/HandleReview",
        DisplayName = "Ratings"
    )]
    [Authorize(
        Roles = "Administrators, WebAdmins, CmsAdmins"
    )]
    public class HandleReviewController : Controller
    {
        private readonly IDataStoreRepository _repository;
        private readonly IMovieRepository _movieRepository;

        public HandleReviewController(IDataStoreRepository repository, IMovieRepository movieRepository)
        {
            _repository = repository;
            _movieRepository = movieRepository;
        }

        public async Task<ActionResult> Index()
        {
            var reviews = _repository.GetAll();

            var movies =  reviews.Select(r => r.MovieId).Distinct()
                .Select(id => _movieRepository.GetMovie(id));

            await Task.WhenAll(movies).ConfigureAwait(false);

            var model = new HandleReviewViewModel
            {
                Movies = reviews.GroupBy( r => r.MovieId).ToDictionary(r => movies.FirstOrDefault(m => m.Result.imdbID == r.Key).Result,r=>r.ToList())
            };
            return View(model);
        }


        [HttpPost]
        public ActionResult DeleteReviews(Guid[] externalIds)
        {
            foreach (var id in externalIds)
            {
                _repository.Delete(id);
            }

            return Json(new { redirect = Url.Action(nameof(Index)) });
        }
    }
}