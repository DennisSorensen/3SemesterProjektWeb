﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.BookingServiceReference;
using Web.CalendarServiceReference;
using Web.DataAccess;
using Web.UserServiceReference;

namespace Web.BusinessLogic
{

    public class BookingControllerBL
    {
        private BookingService bookingService;

        public BookingControllerBL()
        {
            bookingService = new BookingService();
        }

        public void CreateSupportBooking(SupportBooking supportBooking)
        {
            bookingService.CreateSupportbooking(supportBooking);
        }

        public IEnumerable<Department> GetAllDeparments()
        {
            return bookingService.GetAllDepartments();

        }

        public IEnumerable<User> GetAllDepSupport(int id)
        {
            return bookingService.GetAllDepSupport(id);
        }

        public IEnumerable<Booking> GetAllBookingSpecificDay(int calendar_Id, DateTime date)

        {

            return bookingService.GetAllBookingSpecificDay(calendar_Id, date);
        }

        public int GetCalendarId(int userId)
        {
            Calendar calendar = bookingService.GetCalendar(userId);
            int calendar_Id = 0;
            calendar_Id = calendar.Id;

            return calendar_Id;
        }

        public SupportBooking GetSupportBooking(int id)
        {
            return bookingService.GetSupportBooking(id);
        }
    }

    
  


}