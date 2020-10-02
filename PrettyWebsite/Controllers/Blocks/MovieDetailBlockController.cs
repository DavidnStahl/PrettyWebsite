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
    //public class MovieDetailBlockController : BlockController<MovieDetailBlock>
    //{
    //    public override ActionResult Index(MovieDetailBlock currentBlock)
    //    {
    //        var model = new MovieDetailBlockViewModel(currentBlock)
    //        {
    //            Movie = JsonConvert.DeserializeObject<Movie>(ControllerContext.ParentActionViewContext.ViewData["movie"].ToJson()),
    //            Ratings = JsonConvert.DeserializeObject<List<Rating>>(ControllerContext.ParentActionViewContext.ViewData["ratings"].ToJson())
    //        };

    //        return PartialView(model);
    //    }

    //}
}