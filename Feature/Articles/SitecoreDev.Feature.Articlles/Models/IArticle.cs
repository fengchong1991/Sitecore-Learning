using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Articles.Models
{
    public interface IArticle
    {
        string Id { get; }
        string Title { get; }
        string Body { get; }
    }
}