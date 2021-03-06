using System.Web;
using System.Web.Optimization;

namespace StanZoBank
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
						"~/Scripts/jquery.js",
						"~/Scripts/bootstrap.min.js",
						"~/Scripts/jquery.inview.min.js",
						"~/Scripts/wow.min.js",
						"~/Scripts/mousescroll.js",
						"~/Scripts/smoothscroll.js",
						"~/Scripts/jquery.countTo.js",
						"~/Scripts/lightbox.min.js",
						"~/Scripts/main.js"));

			bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
				"~/Scripts/jquery-{version}.js",
				"~/Scripts/bootstrap.bundle.min.js",
				"~/Scripts/jquery.easing.min.js",
				"~/Scripts/sb-admin-2.min.js",
				"~/Scripts/scripts.js"
			));
			bundles.Add(new StyleBundle("~/Content/css").Include(
				"~/Content/animate.min.css",
				"~/Content/font-awesome.min.css",
				"~/Content/lightbox.css",
				"~/Content/main.css",
				"~/Content/presets/preset1.css",
				"~/Content/responsive.cs"));
		}
	}
}
