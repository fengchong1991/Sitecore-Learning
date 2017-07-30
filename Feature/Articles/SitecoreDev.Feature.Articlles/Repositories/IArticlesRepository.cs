using Sitecore.Data.Items;
using SitecoreDev.Feature.Articles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Articles.Repositories
{
    public interface IArticlesRepository
    {
        IArticle GetArticleContent(string contentGuid);
    }
}