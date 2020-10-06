using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using PrettyWebsite.Models.Pages;

namespace PrettyWebsite.Models.Containers
{
    [ContentType(DisplayName = "Category Container", GUID = "70bd6db9-fda0-46dc-a6f5-741f43f8cd60", Description = "")]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[]
        {
            typeof(NewsPage),
        },
        ExcludeOn = new []
        {
            typeof(StartPage)
        }
    )]
    public class CategoryNewsContainer : NewsContainer
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */
    }
}