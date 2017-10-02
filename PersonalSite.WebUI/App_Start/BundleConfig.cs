using System.Web;
using System.Web.Optimization;

namespace PersonalSite.WebUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/test.css",
                "~/Content/ooer.css"));
            bundles.Add(new ScriptBundle("~/Scripts").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/GoogleAnalytics.js",
                "~/Scripts/GTMFileDownload.js",
                "~/Scripts/modernizr-*",
                "~/Scripts/MoveImage.js"));
        }
    }
}