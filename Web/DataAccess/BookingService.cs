using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.DataAccess
{
    public class BookingService
    {
        BookingServiceReference.IBookingService bookingService = new BookingServiceReference.BookingServiceClient();

        public BookingService()
        {

        }
        public void CreateSupportbooking(BookingServiceReference.SupportBooking supportBooking)
        {
            bookingService.CreateSupportBooking(supportBooking);
        }
    }
}