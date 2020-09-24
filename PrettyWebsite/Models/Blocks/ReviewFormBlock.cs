using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace PrettyWebsite.Models.Blocks
{
    [ContentType(DisplayName = "ReviewFormBlock", GUID = "ee99f934-97be-4b00-a088-24787a2b0073", Description = "")]
    public class ReviewFormBlock : SiteBlockData
    {
        
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Name Labeltext",
        Description = "",
        GroupName = SystemTabNames.Content,
        Order = 20)]
        public virtual string NameLabel { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Text Labeltext",
        Description = "",
        GroupName = SystemTabNames.Content,
        Order = 30)]
        public virtual string TextLabel { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Rating Labeltext",
        Description = "",
        GroupName = SystemTabNames.Content,
        Order = 40)]
        public virtual string RatingLabel { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Star description",
        Description = "Description how to rate with stars",
        GroupName = SystemTabNames.Content,
        Order = 50)]
        public virtual string StarDescription { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Rating response text",
        Description = "Description on how many stars that was rated",
        GroupName = SystemTabNames.Content,
        Order = 60)]
        public virtual string RatingResponse { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Text label for stars",
        Description = "English version should be star(s)",
        GroupName = SystemTabNames.Content,
        Order = 70)]
        public virtual string HelpLabelStars { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Submit button text",
        Description = "",
        GroupName = SystemTabNames.Content,
        Order = 80)]
        public virtual string SubmitButtonText { get; set; }



    }
}