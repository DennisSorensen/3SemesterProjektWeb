using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.BookingServiceReference;
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

    }

    
  


}