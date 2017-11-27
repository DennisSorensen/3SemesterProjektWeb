using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.BookingServiceReference;

namespace Web.DataAccess
{
    public class BookingService
    {
        //Laver en instans af vores service reference, sådan vi kan kalde dem
        IBookingService bookingService = new BookingServiceClient();

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

        //public List<Department> GetAllDepartments()
        //{
        //    return null;

        //}
    }
}