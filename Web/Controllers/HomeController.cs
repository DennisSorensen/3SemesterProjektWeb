using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Booking()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}