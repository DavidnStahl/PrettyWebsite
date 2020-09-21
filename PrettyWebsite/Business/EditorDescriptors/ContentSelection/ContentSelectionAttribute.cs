using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Business.EditorDescriptors.ContentSelection
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ContentSelectionAttribute : Attribute
    {
        public ContentSelectionAttribute(Type contentType)
        {
            ContentType = contentType;
        }

        public Type ContentType { get; set; }
    }
}