using System.Web;
using System.Web.Optimization;

namespace WeGo
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"



                      ));

            bundles.Add(new ScriptBundle("~/bundles/themeappjavascript").Include(
                      "~/Scripts/appzia/fastclick.js",
                      "~/Scripts/appzia/app.js",
                      "~/Scripts/appzia/dashboard.js",
                      "~/Scripts/appzia/detect.js",
                      "~/Scripts/appzia/jquery.nicescroll.js",
                      "~/Scripts/appzia/jquery..blockUIjs",
                      "~/Scripts/appzia/jquery.slimscroll.js",
                      "~/Scripts/appzia/morris.min.js",
                      "~/Scripts/appzia/wave.js",
                      "~/Scripts/appzia/wow.min.js",
                      "~/Scripts/appzia/raphael-min.js",
                      "~/Scripts/appzia/jquery.bootstrap.wizard.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themeappcss").Include(

                     "~/Content/Appzia/icons.css",
                     "~/Content/Appzia/morris.css",
                     "~/Content/Appzia/style.css"


                     ));
        }
    }
}
