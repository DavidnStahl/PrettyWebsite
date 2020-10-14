using EPiServer.Web.Mvc;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Blocks;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Blocks
{
    public class FooterBlockController : BlockController<FooterBlock>
    {
        public override ActionResult Index(FooterBlock currentBlock)
        {
            var model = new FooterBlockViewModel(currentBlock);
            return PartialView(model);
        }
    }
}
