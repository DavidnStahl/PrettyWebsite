using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.Web.Mvc;

namespace PrettyWebsite.Controllers.Base
{
    public class BasePartialController<T> : PartialContentController<T> where T : IContentData
    {

    }
}