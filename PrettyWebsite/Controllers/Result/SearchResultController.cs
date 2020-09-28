using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Find.UnifiedSearch;
using PrettyWebsite.Models.Forms;
using PrettyWebsite.Models.ViewModels.Result;
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
            
            if (!string.IsNullOrWhiteSpace(query) && type == "1")
            {
                var model = new SearchFormModel
                {
                    SearchResult = await _movieRepository.SearchByTitle(query)
                };

                return PartialView("_MovieSearchResult",model);
            }
            else if(!string.IsNullOrWhiteSpace(query) && type == "2")
            {
                var hitSpec = new HitSpecification
                {
                    ExcerptLength = 255
                };

                var model = new FindResultViewModel
                {
                    Result = SearchClient.Instance.UnifiedSearchFor(query, Language.English)
                                                  .UsingSynonyms()
                                                  .ApplyBestBets()
                                                  .Take(100)
                                                  .GetResult(hitSpec)
                };

                return PartialView("_FindSearchResult", model);
            }

            return PartialView();
        }
       
    }
}