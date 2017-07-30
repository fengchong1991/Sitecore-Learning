
using Glass.Mapper.Sc;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using SitecoreDev.Feature.Articles.Models;
using System;

namespace SitecoreDev.Feature.Articles.Repositories
{
    public class SitecoreArticlesRepository : IArticlesRepository
    {
        private readonly ISitecoreContext _sitecoreContext;

        public SitecoreArticlesRepository()
        {
            //_database = Context.Database;
            _sitecoreContext = new SitecoreContext();
        }

        public IArticle GetArticleContent(string contentGuid)
        {
            Assert.ArgumentNotNullOrEmpty(contentGuid, "contentGuid");
            return _sitecoreContext.GetItem<IArticle>(Guid.Parse(contentGuid));
        }

    }
}