﻿using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.ViewModels.Blocks
{
    public class RssFeedBlockViewModel : BlockViewModel<RssFeedBlock>
    {
        public List<RssFeed> RssFeed { get; set; }
        public RssFeedBlockViewModel(RssFeedBlock currentBlock) : base(currentBlock)
        {

        }
    }
}