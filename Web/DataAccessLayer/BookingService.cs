using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.DataAccessLayer
{
    public class BookingService
    {
        //Vi laver en istans af vores service reference client
        BookingServiceReference.IBookingService bookingService = new BookingServiceReference.BookingServiceClient();

        public void createSupportBooking(BookingServiceReference.SupportBooking supportBooking)
        {
            bookingService.CreateSupportBooking(supportBooking);

        }
        public BookingServiceReference.SupportBooking GetSupportBooking(int id)
        {
            return bookingService.GetSupportBooking(id);
        }
    }

}