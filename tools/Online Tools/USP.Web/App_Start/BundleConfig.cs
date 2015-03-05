using System.Web;
using System.Web.Optimization;

namespace USP.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Scripts
            bundles.Add(
                new ScriptBundle("~/scripts/validation").Include(
                    "~/Content/scripts/jquery.validate*",
                    "~/Content/scripts/modernizr-*")
                );

            bundles.Add(
                new ScriptBundle("~/scripts/character-gen").Include(
                    "~/Content/scripts/bootstrap-slider.js",
                    "~/Content/scripts/character-gen-site.js")
                );

            bundles.Add(
                new ScriptBundle("~/scripts/tour").Include(
                    "~/Content/scripts/bootstrap-tour.min.js",
                    "~/Content/scripts/character-gen-tour.js")
                );

            #endregion

            #region Styles
            bundles.Add(new StyleBundle("~/content/css").Include(
                      "~/Content/styles/freelancer.css",
                      "~/Content/styles/site.css"));

            bundles.Add(new StyleBundle("~/content/tour").Include(
                      "~/Content/styles/bootstrap-tour.min.css"));

            bundles.Add(new StyleBundle("~/content/character-gen").Include(
                      "~/Content/styles/bootstrap-slider.css",
                      "~/Content/styles/character-gen.css"));
            #endregion

            BundleTable.EnableOptimizations = true;
        }
    }
}
