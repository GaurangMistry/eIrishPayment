using System.Web;
using System.Web.Optimization;

namespace eIrishPayment
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/plugins/jquery/jquery-1.11.1.min.js",
                        "~/assets/plugins/bootstrap/js/bootstrap.min.js",
                        "~/assets/plugins/bootstrap-select/js/bootstrap-select.min.js",
                        "~/assets/plugins/superfish/js/superfish.min.js",
                        "~/assets/plugins/prettyphoto/js/jquery.prettyPhoto.js",
                        "~/assets/plugins/owl-carousel2/owl.carousel.min.js",
                        "~/assets/plugins/jquery.sticky.min.js",
                        "~/assets/plugins/jquery.easing.min.js",
                        "~/assets/plugins/jquery.smoothscroll.min.js",
                        "~/assets/plugins/smooth-scrollbar.min.js",
                        "~/assets/js/theme.js",
                        "~/assets/plugins/jquery.cookie.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*",
                        "~/assets/plugins/modernizr.custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/assets/plugins/bootstrap/css/bootstrap.min.css",
                        "~/assets/plugins/bootstrap-select/css/bootstrap-select.min.css",
                        "~/assets/plugins/fontawesome/css/font-awesome.min.css",
                        "~/assets/plugins/prettyphoto/css/prettyPhoto.css",
                        "~/assets/plugins/owl-carousel2/assets/owl.carousel.min.css",
                        "~/assets/plugins/owl-carousel2/assets/owl.theme.default.min.css",
                        "~/assets/plugins/animate/animate.min.css",
                        "~/assets/css/theme.css",
                        "~/assets/css/theme-green-1.css"));

        }
    }
}
