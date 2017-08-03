using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Search.Search
{
    public class FacetedSearchResults<T> : IFacetedSearchResults<T> where T : SearchResultItem
    {
        public IEnumerable<T> Results { get; set; }
        public IEnumerable<Facet> Facets { get; set; }
    }
}