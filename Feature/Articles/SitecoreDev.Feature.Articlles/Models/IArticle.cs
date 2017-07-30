using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Articles.Models
{
    //public interface IArticle
    //{
    //    Guid Id { get; }
    //    string Title { get; }
    //    string Body { get; }
    //}

    [SitecoreType(AutoMap = true)]
    public interface IArticle
    {
        [SitecoreId]
        Guid Id { get; }
        [SitecoreField(FieldName = "Title")]
        string Title { get; }
        [SitecoreField(FieldName = "Body")]
        string Body { get; }
        [SitecoreField(FieldName = "Author Name")]
        string AuthorName { get; }
    }
}