using System.Web;
using System.Web.Optimization;

namespace USP.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/scripts/validation").Include(
                    "~/Content/scripts/jquery.validate*",
                    "~/Content/scripts/modernizr-*")
                );

            bundles.Add(
                new ScriptBundle("~/scripts/tour").Include(
                    "~/Content/scripts/bootstrap-tour.min.js",
                    "~/Content/scripts/character-gen-tour.js")
                );

            bundles.Add(new StyleBundle("~/content/css").Include(
                      "~/Content/styles/freelancer.css",
                      "~/Content/styles/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
