using PrettyWebsite.Models.Forms;
using PrettyWebsite.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PrettyWebsite.Controllers.Form
{
    public class SearchResultController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public SearchResultController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public async Task<ActionResult> Submit(string type ,string query)
        {
            var model = new SearchFormModel();
            if (!string.IsNullOrWhiteSpace(query))
            {
                model.SearchResult = await _movieRepository.SearchByTitle(query);

                return PartialView("_MovieSearchResult",model);
            }

            return PartialView();
        }
    }
}