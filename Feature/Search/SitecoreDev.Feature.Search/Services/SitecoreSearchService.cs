using SitecoreDev.Feature.Search.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreDev.Feature.Search.Models;

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

    }
}