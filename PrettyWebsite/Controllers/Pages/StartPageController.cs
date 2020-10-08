﻿using System.Web.Mvc;
using EPiServer;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Pages;

namespace PrettyWebsite.Controllers.Pages
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        private readonly IContentRepository _contentRepository;

        public StartPageController(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }
        public ActionResult Index(StartPage currentPage)
        {
            var model = new StartPageViewModel(currentPage);           
            return View(model);
        }

    }
}