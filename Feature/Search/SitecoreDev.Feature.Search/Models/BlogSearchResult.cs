using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Search.Models
{
    public class BlogSearchResult : SearchResultItem
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}