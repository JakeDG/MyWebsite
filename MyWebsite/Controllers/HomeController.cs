using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A short summary.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to contact me by sending me an email at the address below.";

            return View();
        }
    }
}