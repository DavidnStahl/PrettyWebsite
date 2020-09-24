using EPiServer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Models
{
    public class User
    {
        public List<string> MovieList { get; set; }

        public List<string> ReviewRatedList { get; set; }
    }
}