﻿using System.Web;
using System.Web.Optimization;

namespace iJobs
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/assets/semantic/dist/semantic.min.js",
                      "~/assets/js/owl.carousel.js",
                      "~/assets/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/css/main.css",
                      "~/assets/css/owl.carousel.css",
                      "~/assets/semantic/dist/semantic.min.css",
                      "~/assets/semantic/dist/components/container.css"));
        }
    }
}
