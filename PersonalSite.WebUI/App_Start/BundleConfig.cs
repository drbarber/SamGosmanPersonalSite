using System.Web.Optimization;

namespace PersonalSite.WebUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css"));
            bundles.Add(new ScriptBundle("~/Scripts").Include("~/Scripts/*.js"));
        }
    }
}