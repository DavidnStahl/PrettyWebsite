﻿using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using PrettyWebsite.Business.UIDescriptors.FolderIcons;
using PrettyWebsite.Business.UIDescriptors.SettingIcons;
using PrettyWebsite.Models.Interfaces;
using PrettyWebsite.Models.Pages;

namespace PrettyWebsite.Models.Containers
{
    [ContentType(
        DisplayName = "Container: News",
        GUID = "b1bbd9f7-47e8-4689-8483-2b9ed167c964",
        Description = "",
        GroupName = Global.GroupNames.Specialized
    )]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[]
        {
             typeof(CategoryNewsContainer)
        }
    )]
    public class NewsContainer : SitePageData, IUseFolderIcon, IExcludeFromSiteMap
    {

        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */
    }
}