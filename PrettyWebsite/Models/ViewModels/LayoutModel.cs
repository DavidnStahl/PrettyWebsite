using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using PrettyWebsite.Models.Blocks;
using PrettyWebsite.Models.Pages;

namespace PrettyWebsite.Models.ViewModels
{
    public class LayoutModel
    {
        public SitePageSettings PageSettings { get; set; }

        public IEnumerable<StartPage> StartPages { get; set; }
    }
}