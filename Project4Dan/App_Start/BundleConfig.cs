using System.Web;
using System.Web.Optimization;

namespace Project4Dan
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Content/vendor/bootstrap/js/bootstrap.js",
                      "~/Content/vendor/metisMenu/metisMenu.min.js",
                      "~/Content/dist/js/sb-admin-2.min.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/vendor/font-awesome/css/font-awesome.min.css",
                      "~/Content/vendor/metisMenu/metisMenu.min.css",
                      "~/Content/dist/css/sb-admin-2.min.css"
                      ));

            bundles.Add(new ScriptBundle("~/flowchart").Include(
                "~/Content/vendor/flot/jquery.flot.js",
                "~/Content/vendor/flot/jquery.flot.pie.js"));

            //.IncludeDirectory("~/Content/vendor/flot/", "*.js", true));

        }
    }
}
