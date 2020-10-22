using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell;
using PrettyWebsite.EpiServerDefaultIcon;

namespace PrettyWebsite.Business.UIDescriptors.PageIcons
{
    [UIDescriptorRegistration]
    public class PageIconDescriptor : UIDescriptor<IUsePageIcon>
    {
        public PageIconDescriptor()
        {
            IconClass = EpiserverDefaultContentIcons.ActionIcons.Catalog;
        }
    }

    public interface IUsePageIcon
    {
    }
}