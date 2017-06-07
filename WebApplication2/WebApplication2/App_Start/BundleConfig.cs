using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Optimization;

namespace WebApplication2
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/index").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/knockout-3.4.2.js",
                        "~/Scripts/index/namespace.js",
                        "~/Scripts/index/constants.js",
                        "~/Scripts/index/service.js",
                        "~/Scripts/index/colourviewmodel.js",
                        "~/Scripts/index/indexviewmodel.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
