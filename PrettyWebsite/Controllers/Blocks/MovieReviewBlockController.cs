using EPiServer.Web.Mvc;
using PrettyWebsite.DataStore;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Blocks;
using PrettyWebsite.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Blocks
{
    public class MovieReviewBlockController : BlockController<MovieReviewBlock>
    {
        private readonly IDataStoreRepository _dataStoreRepository;
        public MovieReviewBlockController(IDataStoreRepository dataStoreRepository)
        {
            _dataStoreRepository = dataStoreRepository;
        }
        public ActionResult Index(MovieReviewBlock currentBlock, string id)
        {
            var model = new MovieReviewBlockViewModel(currentBlock);
            model.ReviewDataList = _dataStoreRepository.Get(id);
            return PartialView(model);
        }

        public ActionResult Index(MovieReviewBlock currentBlock, string id, MovieReviewBlockViewModel data)
        {
            ReviewData reviewData = new ReviewData
            {
                MovieId = id,
                Name = data.Name,
                Text = data.Text,
                Rating = data.Rating,
                PubliationDate = DateTimeOffset.Now
            };
            _dataStoreRepository.Save(reviewData);

            var model = new MovieReviewBlockViewModel(currentBlock);
            model.ReviewDataList = _dataStoreRepository.Get(id);
            return PartialView(model);
        }

    }
}