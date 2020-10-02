using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell;
using PrettyWebsite.EpiServerDefaultIcon;

namespace PrettyWebsite.Business.UIDescriptors.VideoIcon
{
    [UIDescriptorRegistration]
    public class VideoIconDescriptor : UIDescriptor<IUseVideoIcon>
    {
        public VideoIconDescriptor()
        {
            
            IconClass = EpiserverDefaultContentIcons.ObjectIcons.Video;
        }
    }
    public interface IUseVideoIcon
    {
    }
}