using EPiServer;
using EPiServer.Core;
using EPiServer.Data;
using EPiServer.Globalization;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using PrettyWebsite.Controllers.Base;
using PrettyWebsite.DataStore;
using PrettyWebsite.Models;
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
                Id = Session["movieId"].ToString()   
            };

            return PartialView(model);
        }
    }
}