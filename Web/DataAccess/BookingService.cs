using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.BookingServiceReference;
using Web.CalendarServiceReference;
using Web.Models;
using Web.UserServiceReference;

namespace Web.DataAccess
{
    public class BookingService
    {
        //Laver en instans af vores service reference, sådan vi kan kalde dem
        IBookingService bookingService = new BookingServiceClient();
        IUserService userService = new UserServiceClient();
        ICalendarService calendarService = new CalendarServiceClient();

        public BookingService()
        {

        }
        public void CreateSupportbooking(SupportBooking supportBooking)
        {
            bookingService.CreateSupportBooking(supportBooking);
        }

        public SupportBooking GetSupportBooking(int id)
        {
            return bookingService.GetSupportBooking(id);
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return userService.GetAllDepartments() ;

        }

        public IEnumerable<User> GetAllDepSupport(int id)
        {

            return userService.GetAllDepSupport(id);
        }

        public IEnumerable<Booking> GetAllBookingSpecificDay(int calendar_Id, DateTime date)
        {
            return bookingService.GetAllBookingSpecificDay(calendar_Id, date);
        }

        public Calendar GetCalendar(int userId)
        {
            return calendarService.Get(userId);
        }
    }
}