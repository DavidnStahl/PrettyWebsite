﻿using EPiServer.Shell;
using PrettyWebsite.EpiServerDefaultIcon;

namespace PrettyWebsite.Business.UIDescriptors.FolderIcons
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