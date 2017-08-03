using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Search.Search
{
    public interface IFacetedSearchResults<T> where T : SearchResultItem
    {
        IEnumerable<T> Results { get; set; }
        IEnumerable<Facet> Facets { get; set; }
    }
}