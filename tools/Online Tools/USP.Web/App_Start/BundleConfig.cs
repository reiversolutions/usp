using System.Web;
using System.Web.Optimization;

namespace USP.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts/jqueryval").Include(
                        "~/Content/scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/scripts/modernizr").Include(
                        "~/Content/scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/content/css").Include(
                      "~/Content/styles/freelancer.css",
                      "~/Content/styles/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
