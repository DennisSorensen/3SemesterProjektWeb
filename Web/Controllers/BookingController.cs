using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Info()
        {
            ViewBag.Message = "info";
            BookingVM book = new BookingVM();
            book.Name = "Her kan du booke en tid til support";

            return View();
        }

        public ActionResult Book()
        {
            ViewBag.Message = "Book tid";
            BookingVM book = new BookingVM();
            book.Name = "Her kan du booke en tid til support";


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}