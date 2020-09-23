using EPiServer.Core;
using EPiServer.Globalization;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using PrettyWebsite.Controllers.Base;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.Forms;
using PrettyWebsite.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Blocks
{
    public class SearchFormBlockController : BaseFormController<SearchFormBlock>
    {
        private readonly IMovieRepository _movieRepository;

        public SearchFormBlockController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public override ActionResult Index(SearchFormBlock currentBlock)
        {
            var pageRouteHelper = ServiceLocator.Current.GetInstance<IPageRouteHelper>();
            var currentBlockLink = ((IContent)currentBlock).ContentLink;

            LoadModelState(currentBlockLink);

            var model = new SearchFormModel()
            {
                CurrentPageLink = pageRouteHelper.PageLink,
                CurrentBlockLink = currentBlockLink,
                CurrentLanguage = ContentLanguage.PreferredCulture.Name,
                ParentBlock = currentBlock
            };

            return PartialView(model);
        }
        [HttpPost]
        public  virtual async Task<ActionResult> Submit(SearchFormModel formModel, SearchFormBlock block, PageData page)
        {
            // var returnUrl = UrlResolver.Current.GetUrl(formModel.CurrentPageLink) + $"MovieDetails?id={Session["newId"]}";
            var model = new SearchFormModel();
            if (ModelState.IsValid)
            {               
                model.SearchResult = await _movieRepository.SearchByTitle(formModel.query);

                return PartialView(model);

            }

            SaveModelState(formModel.CurrentBlockLink);

            return PartialView(model);
        }
    }
}