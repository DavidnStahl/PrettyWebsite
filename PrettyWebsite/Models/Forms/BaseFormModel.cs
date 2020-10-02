using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Framework.Localization;
using EPiServer.ServiceLocation;

namespace PrettyWebsite.Models.Forms
{
    public class BaseFormModel<T> where T : BlockData
    {
        public PageReference CurrentPageLink { get; set; }
        public ContentReference CurrentBlockLink { get; set; }
        public string CurrentLanguage { get; set; }
        public T ParentBlock { get; set; }
    }
}