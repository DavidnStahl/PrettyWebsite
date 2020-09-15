﻿using EPiServer.Web.Mvc;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Blocks;
using PrettyWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Blocks
{
    
    public class RssFeedBlockController : BlockController<RssFeedBlock>
    {
        private readonly IRssFeedService _rssFeedService;
        public RssFeedBlockController(IRssFeedService rssFeedService)
        {
            _rssFeedService = rssFeedService;
        }
        // GET: RssFeed
        public override ActionResult Index(RssFeedBlock currentBlock)
        {
            var model = new RssFeedBlockViewModel(currentBlock);
            model.RssFeed = _rssFeedService.Get();
            return PartialView(model);
        }
    }
}