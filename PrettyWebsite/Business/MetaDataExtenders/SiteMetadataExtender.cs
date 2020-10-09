using EPiServer.Shell.ObjectEditing;
using PrettyWebsite.Models.Pages;
using System;
using System.Collections.Generic;

namespace PrettyWebsite.Business.MetaDataExtenders
{
    public class SiteMetadataExtender : IMetadataExtender
    {
        public void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            foreach (ExtendedMetadata property in metadata.Properties)
            {
                if (property.PropertyName == "icategorizable_category")
                {
                    property.GroupName = "EPiServerCMS_SettingsPanel";
                    property.Order = 1;
                }

                if (property.PropertyName == nameof(SitePageData.Robots))
                {
                    property.GroupName = "EPiServerCMS_SettingsPanel";
                    property.Order = 20;
                }
            }
        }
    }
}