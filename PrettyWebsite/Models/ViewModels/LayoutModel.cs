﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using PrettyWebsite.Models.Pages;

namespace PrettyWebsite.Models.ViewModels
{
    public class LayoutModel
    {
        public IEnumerable<SitePageData> Menu { get; set; }
    }
}