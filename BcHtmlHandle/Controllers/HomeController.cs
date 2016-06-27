using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using Ivony.Html;
using Ivony.Html.Styles;
using Ivony.Html.Parser;

namespace BcHtmlHandle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Title = "Home Page";

            return View();
        }
    }
}
