using EPiServer.Shell;
using PrettyWebsite.EpiServerDefaultIcon;

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