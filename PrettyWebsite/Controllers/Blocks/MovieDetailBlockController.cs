using EPiServer.Forms.Helpers.Internal;
using EPiServer.Web.Mvc;
using Newtonsoft.Json;
using PrettyWebsite.Controllers.Base;
using PrettyWebsite.Models;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Blocks;
using PrettyWebsite.Models.ViewModels.Pages;
using PrettyWebsite.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Blocks
{
    public class MovieDetailBlockController : AsyncBlockController<MovieDetailBlock>
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IDataStoreRepository _dataStoreRepository;


        public MovieDetailBlockController(IMovieRepository movieRepository, IDataStoreRepository dataStoreRepository)
        {
            _movieRepository = movieRepository;
            _dataStoreRepository = dataStoreRepository;
        }
        public override async Task<ActionResult> Index(MovieDetailBlock currentBlock)
        {
            var json = ControllerContext.ParentActionViewContext.ViewData["model"].ToJson();

            var deserializedProduct = JsonConvert.DeserializeObject<MoviePageViewModel>(json);

            var model = new MovieDetailBlockViewModel(currentBlock)
            {
                Movie = await _movieRepository.GetMovie(Session["movieId"].ToString())
            };
            return PartialView(model);
        }

    }
}