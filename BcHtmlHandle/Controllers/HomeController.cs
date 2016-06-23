using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Ivony.Html;
using Ivony.Html.Parser;

namespace BcHtmlHandle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var html = "";
            var htmlParser = new JumonyParser();
            var doc = htmlParser.Parse(html);

            var css_class = doc.Find(".css_class");



            //ViewBag.Title = "Home Page";

            return View();
        }
    }
}
