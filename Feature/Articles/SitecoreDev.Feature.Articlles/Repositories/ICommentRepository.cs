using SitecoreDev.Feature.Articles.Models;
using System.Collections.Generic;

namespace SitecoreDev.Feature.Articles.Repositories
{
    public interface ICommentRepository
    {
        IEnumerable<IComment> GetComments(string blogId);
    }
}