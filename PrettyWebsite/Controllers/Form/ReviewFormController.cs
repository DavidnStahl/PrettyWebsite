using EPiServer;
using EPiServer.Core;
using EPiServer.Globalization;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using PrettyWebsite.Controllers.Base;
using PrettyWebsite.DataStore;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.Forms;
using PrettyWebsite.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Form
{
    public class ReviewFormController : BaseFormController<ReviewFormBlock>
    {
        private readonly IDataStoreRepository _dataStoreRepository;

        public ReviewFormController(IDataStoreRepository dataStoreRepository)
        {
            _dataStoreRepository = dataStoreRepository;
        }
        public override ActionResult Index(ReviewFormBlock currentBlock)
        {
            var pageRouteHelper = ServiceLocator.Current.GetInstance<IPageRouteHelper>();
            var currentBlockLink = ((IContent)currentBlock).ContentLink;

            LoadModelState(currentBlockLink);

            var model = new ReviewFormModel()
            {
                CurrentPageLink = pageRouteHelper.PageLink,
                CurrentBlockLink = currentBlockLink,
                CurrentLanguage = ContentLanguage.PreferredCulture.Name,
                ParentBlock = currentBlock,
                Id = ControllerContext.ParentActionViewContext.ViewData["Id"]?.ToString() ?? string.Empty
            };

            return PartialView(model);
        }

        [HttpPost]
        public virtual ActionResult Submit(ReviewFormModel formModel, ReviewFormBlock block,PageData page)
        {
            var returnUrl = UrlResolver.Current.GetUrl(formModel.CurrentPageLink) + $"MovieDetails?id={formModel.Id}";

            if (ModelState.IsValid)
            {
                Review reviewData = new Review
                {
                    MovieId = formModel.Id,
                    Name = formModel.Author,
                    Text = formModel.Text,
                    Rating = Convert.ToDouble(formModel.Rating),
                    PublicationDate = DateTime.Now
                };

                _dataStoreRepository.Save(reviewData);               
            }

            SaveModelState(formModel.CurrentBlockLink);

            return Redirect(returnUrl);
        }
    }
}