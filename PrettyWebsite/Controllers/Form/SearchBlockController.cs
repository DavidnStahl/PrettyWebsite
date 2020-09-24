using EPiServer.Core;
using EPiServer.Find;
using EPiServer.Globalization;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using PrettyWebsite.Controllers.Base;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.Forms;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Interfaces;
using PrettyWebsite.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PrettyWebsite.Controllers.Blocks
{
    public class SearchFormBlockController : BaseFormController<SearchFormBlock>
    {
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
        
    }
}