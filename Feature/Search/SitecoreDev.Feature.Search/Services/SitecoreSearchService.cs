using SitecoreDev.Feature.Search.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreDev.Feature.Search.Models;
using Sitecore.ContentSearch;
using System.Linq.Expressions;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.Linq.Utilities;

namespace SitecoreDev.Feature.Search.Services
{
    public class SitecoreSearchService : ISearchService
    {
        private readonly ISearchRepository _searchRepository;
        public SitecoreSearchService()
        {
            _searchRepository = new SitecoreSearchRepository();
        }
        public IEnumerable<BlogSearchResult> SearchBlogPosts(string searchTerm)
        {
            return _searchRepository.Search<BlogSearchResult>( q => (q.Title.Contains(searchTerm) || q.Body.Contains(searchTerm)) && q.Path.StartsWith("/sitecore/content/BlogPost/Components"));
        }



        public IFacetedSearchResults<BlogSearchResult> SearchBlogPostsWithFacets(string searchTerm, string[] facets)
        {
            var predicate = PredicateBuilder.True<BlogSearchResult>();
            predicate = predicate.And(i => i.Title.Contains(searchTerm) && i.Path.StartsWith("/sitecore/content/Home"));
            if (facets != null)
            {
                foreach (var facet in facets)
                {
                    predicate = predicate.And(i => i.Categories.Contains(facet));
                }
            }
            return _searchRepository.SearchWithFacets<BlogSearchResult, IEnumerable<string>>(predicate, q => q.Categories);
        }


    }
}