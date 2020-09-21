using PrettyWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Services
{
    public class CookieService : ICookieService
    {

        public string Get(User user)
        {
            //Session[""]
            return "hey";
        }

        public void Save(User user)
        {
            throw new NotImplementedException();
        }
    }
}