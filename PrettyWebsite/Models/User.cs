using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models
{
    public class User
    {
        public int Id { get; set; }

        public List<string> MovieId { get; set; }
    }
}