using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrettyWebsite.Models.ViewModels;

namespace PrettyWebsite.Business
{
    interface IModifyLayout
    {
        void ModifyLayout(LayoutModel layoutModel);
    }
}