using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.ContentSearch;

namespace SitecoreDev.Feature.Search.Search
{
    public class SitecoreSearchRepository : ISearchRepository
    {
        public IEnumerable<T> Search<T>(Expression<Func<T, bool>> query) where T : SearchResultItem
        {
            IEnumerable<T> results = null;

            var index = String.Format("sitecore_web_index");
            using (var context = ContentSearchManager.GetIndex(index).CreateSearchContext())
            {
                results = context.GetQueryable<T>().Where(query).ToList();
            }
            return results;
        }
    }
}