using EPiServer.Find.Framework.UI.Localization;
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
        public override ActionResult Index(MovieReviewBlock currentBlock)
        {
            var model = new MovieReviewBlockViewModel(currentBlock);
            model.ReviewDataList = _dataStoreRepository.Get("tt1375666");
            return PartialView(model);


        }

        [HttpPost]
        public virtual ActionResult Get(MovieReviewBlock currentBlock)
        {
            
            /*var model = new MovieReviewBlockViewModel(currentBlock);
            model.ReviewDataList = _dataStoreRepository.Get(id);*/
            return PartialView();
        }

    }
}