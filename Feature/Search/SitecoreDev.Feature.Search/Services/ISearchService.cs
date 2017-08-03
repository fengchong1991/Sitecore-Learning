using SitecoreDev.Feature.Search.Models;
using SitecoreDev.Feature.Search.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Search.Services
{
    public interface ISearchService
    {
        IEnumerable<BlogSearchResult> SearchBlogPosts(string searchTerm);

        IFacetedSearchResults<BlogSearchResult> SearchBlogPostsWithFacets(string searchTerm, string[] facets);
    }
}