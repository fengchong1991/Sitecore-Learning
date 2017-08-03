using SitecoreDev.Feature.Search.Services;
using SitecoreDev.Feature.Search.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
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
            Func<IEnumerable<string>, string> stringify = (list) =>
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in list)
                    sb.Append(String.Format("{0}; ", item));
                return sb.ToString();
            };
            var resultsViewModel = new SearchResultsViewModel();
            var facetedResults = _searchService.SearchBlogPostsWithFacets
            (viewModel.SearchTerm, null);
            foreach (var result in facetedResults.Results)
            {
                resultsViewModel.Results.Add(new SearchResultViewModel()
                {
                    Id = result.ItemId.ToString(),
                    Title = result.Title,
                    Url = result.Url,
                    Body = result.Body,
                    CategoryList = stringify(result.Categories)
                });
            }
            foreach (var facet in facetedResults.Facets)
            {
                resultsViewModel.Facets.Add(new FacetViewModel()
                {
                    Name = facet.Name,
                    Count = facet.Count
                });
            }
            return PartialView("~/Views/Search/_SearchResults.cshtml", resultsViewModel);
        }
    }
}