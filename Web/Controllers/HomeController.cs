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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Booking()
        {
            BookingVM model = new BookingVM();
            model.Departments = new List<DepartmentVM>();
            
            return View(model);
        }

        public ActionResult Kontakt()
        {
           

            return View();
        }
    }
}