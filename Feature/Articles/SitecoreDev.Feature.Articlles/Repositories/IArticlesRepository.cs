using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Articles.Repositories
{
    public interface IArticlesRepository
    {
        Item GetArticleContent(string contentGuid);
    }
}