using EPiServer.Shell;
using PrettyWebsite.EpiServerDefaultIcon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Business.UIDescriptors.TreeIcons
{
    [UIDescriptorRegistration]
    public class ArticleTreeIconDescriptor : UIDescriptor<IUseArticleTreeIcon>
    {
        public ArticleTreeIconDescriptor()
        {
            IconClass = EpiserverDefaultContentIcons.ObjectIcons.Category;
        }
    }
    public interface IUseArticleTreeIcon
    {
    }
}