using EPiServer.Web.Mvc;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Blocks
{
    public class MovieReviewBlockController : BlockController<MovieReviewBlock>
    {
        public override ActionResult Index(MovieReviewBlock currentBlock)
        {
            var model = new MovieReviewBlockViewModel(currentBlock);
            return PartialView(model);
        }
    }
}