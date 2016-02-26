using System.Web;
using System.Web.Optimization;

namespace Webshop
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                "~/Scripts/plugins/charts/sparkline.min.js",

                "~/Scripts/plugins/forms/uniform.min.js",
                "~/Scripts/plugins/forms/select2.min.js",
                "~/Scripts/plugins/forms/inputmask.js",
                "~/Scripts/plugins/forms/autosize.js",
                "~/Scripts/plugins/forms/inputlimit.min.js",
                "~/Scripts/plugins/forms/listbox.js",
                "~/Scripts/plugins/forms/multiselect.js",
                "~/Scripts/plugins/forms/validate.min.js",
                "~/Scripts/plugins/forms/tags.min.js",
                "~/Scripts/plugins/forms/switch.min.js",

                "~/Scripts/plugins/forms/uploader/plupload.full.min.js",
                "~/Scripts/plugins/forms/uploader/plupload.queue.min.js",

                "~/Scripts/plugins/forms/wysihtml5/wysihtml5.min.js",
                "~/Scripts/plugins/forms/wysihtml5/toolbar.js",

                "~/Scripts/plugins/interface/daterangepicker.js",
                "~/Scripts/plugins/interface/fancybox.min.js",
                "~/Scripts/plugins/interface/moment.js",
                "~/Scripts/plugins/interface/jgrowl.min.js",
                "~/Scripts/plugins/interface/datatables.min.js",
                "~/Scripts/plugins/interface/colorpicker.js",
                "~/Scripts/plugins/interface/fullcalendar.min.js",
                "~/Scripts/interface/timepicker.min.js",
                "~/Scripts/application.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/styles.css",
                      "~/Content/londinium-theme.css",
                      "~/Content/icons.css",
                      "~/Content/site.css"));

        }
    }
}
