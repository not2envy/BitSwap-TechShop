using System.Web.Optimization;

namespace BitSwap_TechShop
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

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
                      "~/Content/styles/bootstrap4/bootstrap.min.css",
                      "~/Content/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                      "~/Content/plugins/OwlCarousel2-2.2.1/owl.carousel.css",
                      "~/Content/plugins/OwlCarousel2-2.2.1/owl.theme.default.css",
                      "~/Content/plugins/OwlCarousel2-2.2.1/animate.css",
                      "~/Content/styles/main_styles.css",
                      "~/Content/styles/responsive.css"));

            bundles.Add(new ScriptBundle("~/bundles/js")
               .Include(
                     "~/Content/js/jquery-3.2.1.min.js",
                     "~/Content/styles/bootstrap4/popper.js",
                     "~/Content/styles/bootstrap4/bootstrap.min.js",
                     "~/Content/plugins/greensock/TweenMax.min.js",
                     "~/Content/plugins/greensock/TimelineMax.min.js",
                     "~/Content/plugins/scrollmagic/ScrollMagic.min.js",
                     "~/Content/plugins/greensock/animation.gsap.min.js",
                     "~/Content/plugins/greensock/ScrollToPlugin.min.js",
                     "~/Content/plugins/OwlCarousel2-2.2.1/owl.carousel.js",
                     "~/Content/plugins/Isotope/isotope.pkgd.min.js",
                     "~/Content/plugins/easing/easing.js",
                     "~/Content/plugins/parallax-js-master/parallax.min.js",
                     "~/Content/js/custom.js"));
        }
    }
}
