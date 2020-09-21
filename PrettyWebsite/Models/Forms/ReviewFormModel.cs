using PrettyWebsite.Models.Blocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.Forms
{
    public class ReviewFormModel : BaseFormModel<ReviewFormBlock>
    {
        public string Id { get; set; }

        [DisplayName("Author")]
        [Required]
        public string Author { get; set; }

        [DisplayName("Text")]
        [Required]

        public string Text { get; set; }
        [Required]
        public int Rating { get; set; }
    }
}