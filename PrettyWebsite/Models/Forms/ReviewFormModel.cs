using PrettyWebsite.Models.Blocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models.Forms
{
    public class ReviewFormModel
    {
        public string Id { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Text { get; set; }

        public int Rating { get; set; }
    }
}