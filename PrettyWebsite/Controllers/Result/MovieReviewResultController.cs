using System.Collections.Generic;
using System.Web.Mvc;
using EPiServer.Data;
using PrettyWebsite.Models;
using PrettyWebsite.Models.ViewModels.Result;
using PrettyWebsite.Repositories.Interfaces;

namespace PrettyWebsite.Controllers.Result
{
    public class MovieReviewResultController : Controller
    {
        private readonly IDataStoreRepository _dataStoreRepository;

        public MovieReviewResultController(IDataStoreRepository dataStoreRepository)
        {
            _dataStoreRepository = dataStoreRepository;
        }
         
        public ActionResult Index()
        {
            var user = Session["User"] is User sessionUser ? sessionUser : new User
            {
                MovieList = new List<string>(),
                ReviewRatedList = new List<string>()
            };

            var model = new MovieReviewResultViewModel
            { 
                ReviewDataList = _dataStoreRepository.Get(Session["movieId"].ToString()),
                ReviewRatedList = user.ReviewRatedList
            };
            
            return PartialView("_MovieReviewResult",model);
        }

        [HttpGet]
        public ActionResult ReviewRating(string id,string rating)
        {
            Identity.TryParse(id, out var identity);

            _dataStoreRepository.SaveRating(identity, rating);

            var user = Session["User"] as User;
            user?.ReviewRatedList.Add(id);

            return RedirectToAction(nameof(Index));
        }
    }
}