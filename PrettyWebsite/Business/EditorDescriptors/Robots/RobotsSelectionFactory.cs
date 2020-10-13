using EPiServer.Shell.ObjectEditing;
using PrettyWebsite.Business.Constants;
using System.Collections.Generic;

namespace PrettyWebsite.Business.EditorDescriptors.Robots
{
    public class RobotsSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            yield return new SelectItem { Text = Indexing.IndexFollow, Value = Indexing.IndexFollow };
            yield return new SelectItem { Text = Indexing.IndexNoFollow, Value = Indexing.IndexNoFollow };
            yield return new SelectItem { Text = Indexing.NoIndexFollow, Value = Indexing.NoIndexFollow };
            yield return new SelectItem { Text = Indexing.NoIndexNoFollow, Value = Indexing.NoIndexNoFollow };
        }
    }
}