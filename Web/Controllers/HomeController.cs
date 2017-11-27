﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.DataAccess;
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
            BookingVM bookingVM = new BookingVM();
            bookingVM.Departments = new List<DepartmentVM>();
            BookingService bookingService = new BookingService();

           //bookingVM.Departments = bookingService.GetAllDepartments(....);
            
            return View(bookingVM);
        }

        public ActionResult Kontakt()
        {
           

            return View();
        }
    }
}