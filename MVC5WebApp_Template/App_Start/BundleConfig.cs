using System.Web.Optimization;

namespace MVC5WebApp_Template
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/SiteWide/Scripts").Include(
                "~/Artifacts/Vendors/JQuery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/SiteWide/Scripts").Include(
                "~/Artifacts/Vendors/JQuery/jquery.validate*"));

            bundles.Add(new Bundle("~/SiteWide/Scripts").Include(
                "~/Artifacts/Scripts/SiteWide.js",
                "~/Artifacts/Vendors/Bootstrap 5.0.2/js/bootstrap.bundle.js"));

            bundles.Add(new StyleBundle("~/SiteWide/Style").Include(
                "~/Artifacts/Styles/SiteWide.css",
                "~/Artifacts/Vendors/Bootstrap 5.0.2/css/bootstrap.css"));
        }
    }
}