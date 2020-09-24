using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "MovieDetailBlock", GUID = "ab6deed5-0d18-48ec-8cc7-184e5ef9ef00", Description = "")]
    public class MovieDetailBlock : SiteBlockData
    {
        
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Title { get; set; }
        [CultureSpecific]
        [Display(
            Name = "Genre label",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string GenreLabel { get; set; }
        [CultureSpecific]
        [Display(
            Name = "Director Label",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string DirectorLabel { get; set; }
        [CultureSpecific]
        [Display(
            Name = "Actors Label",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual string ActorsLabel { get; set; }
        [CultureSpecific]
        [Display(
            Name = "Plot Label",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual string PlotLabel { get; set; }
        [CultureSpecific]
        [Display(
            Name = "Ratings Label",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 60)]
        public virtual string RatingsLabel { get; set; }
        [CultureSpecific]
        [Display(
            Name = "Duration Label",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 70)]
        public virtual string DurationLabel { get; set; }

    }
}