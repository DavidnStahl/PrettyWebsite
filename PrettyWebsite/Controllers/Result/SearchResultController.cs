using System.Threading.Tasks;
using System.Web.Mvc;
using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Find.UnifiedSearch;
using PrettyWebsite.Models.Forms;
using PrettyWebsite.Models.ViewModels.Result;
using PrettyWebsite.Repositories.Interfaces;

namespace PrettyWebsite.Controllers.Form
{
    public class SearchResultController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public SearchResultController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpPost]
        public async Task<ActionResult> Submit(string type ,string query)
        {
            
            if (!string.IsNullOrWhiteSpace(query) && type == "1")
            {
                var model = new SearchFormModel
                {
                    SearchResult = await _movieRepository.SearchByTitle(query).ConfigureAwait(false)
                };

                return PartialView("_MovieSearchResult",model);
            }
            var hitSpec = new HitSpecification
            {
                ExcerptLength = 255
            };

            var findModel = new FindResultViewModel
            {
                Result = SearchClient.Instance.UnifiedSearchFor(query, Language.English)
                    .UsingSynonyms()
                    .ApplyBestBets()
                    .Take(100)
                    .GetResult(hitSpec)
            };

            return PartialView("_FindSearchResult", findModel);
        }
       
    }
}