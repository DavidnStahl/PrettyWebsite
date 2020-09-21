using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using PrettyWebsite.EpiServerDefaultIcon;

namespace PrettyWebsite.Business.EditorDescriptors.ContentSelection
{
    [EditorDescriptorRegistration(
        TargetType = typeof(ContentReference))]
    [EditorDescriptorRegistration(
        TargetType = typeof(PageReference))]
    public class ContentSelector : EditorDescriptor
    {
        public override void ModifyMetadata(
            ExtendedMetadata metadata,
            IEnumerable<Attribute> attributes)
        {
            var contentSelectionAttribute = metadata.Attributes
                .OfType<ContentSelectionAttribute>()
                .SingleOrDefault();

            if (contentSelectionAttribute != null)
            {
                SelectionFactoryType = typeof(ContentSelectionFactory<>)
                    .MakeGenericType(contentSelectionAttribute.ContentType);

                ClientEditingClass = "epi-cms/contentediting/editors/SelectionEditor";
            }

            base.ModifyMetadata(metadata, attributes);
        }
    }
}