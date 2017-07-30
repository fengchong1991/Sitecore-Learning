using Sitecore.Pipelines;
using System.Web.Mvc;
using System.Web.Routing;

namespace SitecoreDev.Feature.Search.Pipelines.RegisterRoutes
{
    public class RegisterRoutes
    {
        public void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapRoute("SubmitSearch", "Search/SubmitSearch", new { controller = "Search", action = "SubmitSearch" });
        }
    }
}