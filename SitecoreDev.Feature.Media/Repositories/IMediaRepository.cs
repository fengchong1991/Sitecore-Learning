using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Media.Repositories
{
    public interface IMediaRepository
    {
        Item GetItem(string contentGuid);
    }
}