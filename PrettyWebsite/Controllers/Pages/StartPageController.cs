using System;
using System.Globalization;
using System.Web.Mvc;
using PrettyWebsite.DataStore;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels;
using PrettyWebsite.Models.ViewModels.Pages;
using PrettyWebsite.Repositories.Interfaces;
using PrettyWebsite.Services;

namespace PrettyWebsite.Controllers.Pages
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        private readonly IDataStoreRepository _dataStoreRepository;
        public StartPageController(IDataStoreRepository dataStoreRepository)
        {
            _dataStoreRepository = dataStoreRepository;
        }
        public ActionResult Index(StartPage currentPage, string name = null, string text = null,string rating = null)
        {
            var id = "tt1375666";
            //_dataStoreRepository.Delete(id);
           
            if (name != null)
            {
                Review reviewData = new Review
                {
                    MovieId = id,
                    Name = name,
                    Text = text,
                    Rating = double.Parse(rating),
                    PubliationDate = DateTime.Now
                };
                _dataStoreRepository.Save(reviewData);
            }

            
            
            var y = _dataStoreRepository.Get(id);
            var model = new StartPageViewModel(currentPage);
            return View(model);
        }
    }
}