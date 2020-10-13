using System.ComponentModel.DataAnnotations;

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