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
        [AllowedTypes(typeof(HeaderBlock))]
        public ContentArea Header { get; set; }

        [AllowedTypes(typeof(FooterBlock))]
        public ContentArea Footer { get; set; }
    }
}