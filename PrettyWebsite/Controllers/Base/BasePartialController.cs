using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Web.Mvc;

namespace PrettyWebsite.Controllers.Base
{
    public class BasePartialController<T> : PartialContentController<T> where T : IContentData
    {

    }
}