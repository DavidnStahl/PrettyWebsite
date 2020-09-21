using System.Collections.Generic;
using System.Linq;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;

namespace PrettyWebsite.Business.EditorDescriptors.ContentSelection
{
    public class ContentSelectionFactory<T> : ISelectionFactory
        where T : IContentData
    {
        private Injected<IContentTypeRepository>
            ContentTypeRepository
        { get; set; }
        private Injected<IContentModelUsage>
            ContentModelUsage
        { get; set; }
        private Injected<IContentLoader>
            ContentLoader
        { get; set; }

        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var contentType = ContentTypeRepository.Service.Load<T>();
            if (contentType == null)
            {
                return Enumerable.Empty<SelectItem>();
            }

            var selectItems = ContentModelUsage.Service
                    .ListContentOfContentType(contentType)
                    .Select(x => x.ContentLink.ToReferenceWithoutVersion())
                    .Distinct()
                    .Select(x => ContentLoader.Service.Get<T>(x))
                    .OfType<IContent>()
                    .Select(x => new SelectItem
                        {
                            Text = x.Name,
                            Value = x.ContentLink
                        })
                    .OrderBy(x => x.Text)
                    .ToList();

            selectItems.Insert(0, new SelectItem());
            return selectItems;
        }
    }
}