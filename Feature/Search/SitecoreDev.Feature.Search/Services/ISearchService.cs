using SitecoreDev.Feature.Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Search.Services
{
    public interface ISearchService
    {
        IEnumerable<BlogSearchResult> SearchBlogPosts(string searchTerm);
    }
}