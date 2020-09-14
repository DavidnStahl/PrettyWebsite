using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace PrettyWebsite.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class MaxItemsAttribute : ValidationAttribute
    {
        private int _maxAllowed;

        public MaxItemsAttribute(int MaxItemsAllowed)
        {
            _maxAllowed = MaxItemsAllowed;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var contentArea = value as ContentArea;

            // Get all items or none if null
            var allItems = contentArea?.Items ?? Enumerable.Empty<ContentAreaItem>();

            // Count the unique personalisation group names, replacing empty ones (items which aren't personalised) with a unique name
            var i = 0;
            var maxNumberOfItemsShown = allItems.Select(x => string.IsNullOrEmpty(x.ContentGroup) ? (i++).ToString() : x.ContentGroup).Distinct().Count();

            return (maxNumberOfItemsShown > _maxAllowed) ? new ValidationResult($"The property \"{validationContext.DisplayName}\" is limited to {_maxAllowed} items") : null;
        }

    }
}