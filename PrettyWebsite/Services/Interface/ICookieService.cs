using PrettyWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrettyWebsite.Services
{
    public interface ICookieService
    {
        void Save(User user);

        string Get(User user);
    }
}