using SitecoreDev.Feature.Articles.Repositories;
using SitecoreDev.Feature.Articles.Models;

namespace SitecoreDev.Feature.Articles.Services
{
    public class SitecoreContentService : IContentService
    {
        private readonly IArticlesRepository _repository;
        public SitecoreContentService()
        {
            _repository = new SitecoreArticlesRepository();
        }
        public IArticle GetArticleContent(string contentGuid)
        {
            return _repository.GetArticleContent(contentGuid);
        }
    }
}