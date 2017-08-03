﻿using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Search.Models
{
    public class HasPresentationComputedField :  IComputedIndexField
    {
        public string FieldName { get; set; }
        public string ReturnType { get; set; }
        public object ComputeFieldValue(IIndexable indexable)
        {
            var indexItem = indexable as SitecoreIndexableItem;
            if (indexItem == null)
                return null;
            var item = indexItem.Item;
            if (item?.Visualization.Layout != null)
            {
                return true;
            }
            return null;
        }
    }
}