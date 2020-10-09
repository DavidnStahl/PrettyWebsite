using EPiServer.Shell;
using PrettyWebsite.EpiServerDefaultIcon;

namespace PrettyWebsite.Business.UIDescriptors.SettingIcons
{

    [UIDescriptorRegistration]
    public class SettingsIconDescriptor : UIDescriptor<IUseSettingsIcon>
    {
        public SettingsIconDescriptor()
        {
            IconClass = EpiserverDefaultContentIcons.ActionIcons.Settings;
        }
    }

    public interface IUseSettingsIcon
    {
    }
}