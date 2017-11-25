using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.DataAccess
{
    public class BookingService
    {
        //Laver en instans af vores service reference, sådan vi kan kalde dem
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