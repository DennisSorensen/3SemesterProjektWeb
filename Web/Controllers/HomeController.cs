using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.BookingServiceReference;
using Web.BusinessLogic;
using Web.DataAccess;
using Web.Models;
using Web.UserServiceReference;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        BookingControllerBL bookingControllerBL = new BookingControllerBL();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectDepartment()
        {
            IEnumerable<Department> list = bookingControllerBL.GetAllDeparments();
            DepartmentListVM departmentListVM = new DepartmentListVM();

            foreach (var Department in list)
            {
                DepartmentVM departmentVM = new DepartmentVM();
                departmentVM.Id = Department.Id;
                departmentVM.Name = Department.Name;
                departmentListVM.Departments.Add(departmentVM);

                
            }
            
            return View(departmentListVM);
           
        }

        public ActionResult Kontakt()
        {
           

            return View();
        }

        public ActionResult SelectEmployee(int id)
        {

            IEnumerable<User> List = bookingControllerBL.GetAllDepSupport(id);
            SupporterListVM supporterListVM = new SupporterListVM();

            foreach (var user in List)
            {
                SupporterVM supporterVM = new SupporterVM();
                supporterVM.Id = user.Id;
                supporterVM.FirstName = user.FirstName;
                supporterVM.LastName = user.LastName;
                supporterListVM.Supporters.Add(supporterVM);

            }


            return View(supporterListVM);
        }

        public ActionResult SelectDate(int id)
        {
            ViewBag.CurrentId = id;
            BookingSpecificDayListVM bookingSpecificDayListVM = new BookingSpecificDayListVM();
            return View(bookingSpecificDayListVM);
        }
        
       [HttpPost]
       public ActionResult SelectDate(int userId, DateTime date)
        {
            ViewBag.HasClicked = true;
           int calendar_Id = bookingControllerBL.GetCalendarId(userId);

           IEnumerable <Booking> List = bookingControllerBL.GetAllBookingSpecificDay(calendar_Id, date);
           BookingSpecificDayListVM bookingSpecificDayListVM = new BookingSpecificDayListVM();
           foreach (var booking in List)
            {
                BookingVM bookingVM = new BookingVM();
                bookingVM.StartDate = booking.StartDate;
                bookingVM.EndDate = booking.EndDate;
                
                bookingSpecificDayListVM.Bookings.Add(bookingVM);

            }

            return View(bookingSpecificDayListVM);

        }

       // public ActionResult FinalizeBooking()
        //{
          //  return View();

//        }
        
    }
}