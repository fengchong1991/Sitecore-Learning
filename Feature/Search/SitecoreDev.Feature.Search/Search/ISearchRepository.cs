using Sitecore.ContentSearch.SearchTypes;
using SitecoreDev.Feature.Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SitecoreDev.Feature.Search.Search
{
    public interface ISearchRepository
    {
        IEnumerable<T> Search<T>(Expression<Func<T, bool>> query) where T : SearchResultItem;
        IFacetedSearchResults<T> SearchWithFacets<T, TFacetKey>(Expression<Func<T, bool>> query, Expression<Func<T, TFacetKey>> facetOn) where T : SearchResultItem;

    }
}