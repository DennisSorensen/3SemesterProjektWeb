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

        public ActionResult SelectDate(int Id)
        {
            ViewBag.CurrentId = Id;
            BookingSpecificDayListVM bookingSpecificDayListVM = new BookingSpecificDayListVM();
            
            return View(bookingSpecificDayListVM);
        }
        
       [HttpPost]
       public ActionResult SelectDate(int userId, DateTime date)
        {
            ViewBag.HasClicked = true;
            ViewBag.CurrentId = userId;
            ViewBag.PickedDate = date;
           
           int calendar_Id = bookingControllerBL.GetCalendarId(userId);

            ViewBag.CalendarId = calendar_Id;

           IEnumerable<Booking> List = bookingControllerBL.GetAllBookingSpecificDay(calendar_Id, date);
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
        [HttpPost]
        public ActionResult timeSelected(FormCollection collection)
        {
            

            string startHour = collection["hour"];
            string startMinut = collection["minut"];
            string calendarId = collection["calendar_Id"];
            string userId = collection["userId"];
            string date = collection["date"];

            TempData["hour"] = startHour;
            TempData["minut"] = startMinut;
            TempData["calendar_Id"] = calendarId;
            TempData["userId"] = userId;
            TempData["date"] = date;
            return RedirectToAction("FinalizeBooking");

        }
        public ActionResult FinalizeBooking()
        {
            string hour = TempData["hour"].ToString();
            string minut = TempData["minut"].ToString();
            string calendar_Id = TempData["calendar_Id"].ToString();
            string userId = TempData["userId"].ToString();
            string date = TempData["date"].ToString();
            
            // den "gamle" date med 00 timer bliver lavet om til kundens valgte timer
            DateTime PickedDate = Convert.ToDateTime(date);
            TimeSpan ts = new TimeSpan(Convert.ToInt32(hour), Convert.ToInt32(minut), 0);
            PickedDate = PickedDate.Date + ts;

            // ny og opdateret date sættes ind i booking sammen med resten af variablerne
            TempData["booking"] = new BookingFullVM() {UserId = Convert.ToInt32(userId), CalendarId = Convert.ToInt32(calendar_Id), StartDate = PickedDate};

          
            return View();

       }
        [HttpPost]
        public ActionResult InformationCollection (FormCollection collection)
        {
            string firstName = collection["firstName"];
            string lastName = collection["lastName"];
            string phone = collection["phone"];
            string description = collection["description"];
            var bookingFullVM = TempData["booking"] as BookingFullVM;

            bookingFullVM.FirstName = firstName;
            bookingFullVM.LastName = lastName;
            bookingFullVM.Phone = Convert.ToInt32(phone);
            bookingFullVM.Description = description;

            SupportBooking supportBooking = new SupportBooking();
            supportBooking.User_Id = bookingFullVM.UserId;
            supportBooking.Calendar_Id = bookingFullVM.CalendarId;
            supportBooking.FirstName = bookingFullVM.FirstName;
            supportBooking.LastName = bookingFullVM.LastName;
            supportBooking.Phone = bookingFullVM.Phone;
            supportBooking.Description = bookingFullVM.Description;
            supportBooking.BookingType = "support";
            supportBooking.StartDate = bookingFullVM.StartDate;
            supportBooking.EndDate = bookingFullVM.StartDate.AddMinutes(30.0);

            bookingControllerBL.CreateSupportBooking(supportBooking);

            return RedirectToAction("BookingSuccess",new { id = supportBooking.Id });
        }

        public ActionResult BookingSuccess(int id)
        {

            BookingFullVM bookingFullVM = bookingControllerBL.GetBooking(id);
            

            

           


            return View(bookingFullVM);
        }







    }
}