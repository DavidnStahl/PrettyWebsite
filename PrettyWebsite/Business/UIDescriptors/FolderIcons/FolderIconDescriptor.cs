using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell;
using PrettyWebsite.EpiServerDefaultIcon;

namespace PrettyWebsite.Business.UIDescriptors.SettingIcons
{

    [UIDescriptorRegistration]
    public class FolderIconDescriptor : UIDescriptor<IUseFolderIcon>
    {
        public FolderIconDescriptor()
        {
            IconClass = EpiserverDefaultContentIcons.ActionIcons.Folder;
        }
    }
    public interface IUseFolderIcon
    {
    }
}