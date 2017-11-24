using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.BookingServiceReference;
using Web.DataAccessLayer;

namespace Web.BLL
{
    public class BookingController
    {
        private BookingService bookingService;

        public BookingController()
        {
            bookingService = new BookingService();
        }

        public void Create (SupportBooking supportBooking)
        {
            bookingService.CreateSupportBooking(supportBooking);
        }

        public void Delete(int Id)
        {

        }

        public Booking GetSupportBooking(int Id)
        {
            return null;
        }

        public void Edit(Booking booking)
        {

        }
    }
}