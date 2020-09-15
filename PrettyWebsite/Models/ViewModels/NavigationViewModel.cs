﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrettyWebsite.Models.Pages;
using PrettyWebsite.Models.ViewModels.Pages;

namespace PrettyWebsite.Models.ViewModels
{
    public class NavigationViewModel
    {
        public IEnumerable<SitePageData> Menu { get; set; }
    }
}