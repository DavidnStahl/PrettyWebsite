﻿using EPiServer.Web.Mvc;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Blocks;
using PrettyWebsite.Services;
using System.Web.Mvc;
using PrettyWebsite.Services.Interface;

namespace PrettyWebsite.Controllers.Blocks
{
    public class RssFeedBlockController : BlockController<RssFeedBlock>
    {
        private readonly IRssFeedService _rssFeedService;

        public RssFeedBlockController(IRssFeedService rssFeedService)
        {
            _rssFeedService = rssFeedService;
        }

        [OutputCache(Duration = 3600)]
        public override ActionResult Index(RssFeedBlock currentBlock)
        {
            var model = new RssFeedBlockViewModel(currentBlock)
            {
                RssFeed = _rssFeedService.Get()
            };

            return PartialView(model);
        }
    }
}