using SitecoreDev.Feature.Search.Services;
using SitecoreDev.Feature.Search.ViewModels;
using System.Web.Mvc;

namespace SitecoreDev.Feature.Search.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchService _searchService;
        public SearchController()
        {
            _searchService = new SitecoreSearchService();
        }

        public ViewResult BlogSearch()
        {
            return View(new BlogSearchViewModel());
        }

        [HttpPost]
        public PartialViewResult SubmitSearch(BlogSearchViewModel viewModel)
        {
            var resultsViewModel = new SearchResultsViewModel();
            var results = _searchService.SearchBlogPosts(viewModel.SearchTerm);
            foreach (var result in results)
            {
                resultsViewModel.Results.Add(new SearchResultViewModel()
                {
                    Id = result.ItemId.ToString(),
                    Title = result.Title,
                    Url = result.Url
                });
            }
            return PartialView("~/Views/Search/_SearchResults.cshtml", resultsViewModel);
        }
    }
}