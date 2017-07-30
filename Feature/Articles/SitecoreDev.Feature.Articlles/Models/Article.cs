﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Articles.Models
{
    public class Article : IArticle
    {
        public Guid Id { get; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string AuthorName { get; set; }
    }
}