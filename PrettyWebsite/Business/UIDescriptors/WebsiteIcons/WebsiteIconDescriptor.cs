using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell;
using PrettyWebsite.EpiServerDefaultIcon;

namespace PrettyWebsite.Business.UIDescriptors.WebsiteIcons
{
    [UIDescriptorRegistration]
    public class WebsiteIconDescriptor : UIDescriptor<IUseWebsiteIcon>
    {
        public WebsiteIconDescriptor()
        {
            IconClass = EpiserverDefaultContentIcons.ActionIcons.Website;
        }
    }

    public interface IUseWebsiteIcon
    {
    }
}