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
    
        public BookingController()
        {

        }

        public void Create (SupportBooking supportBooking)
        {
            BookingService.CreateSupportBooking()
        }

        public void Delete(int Id)
        {

        }

        public Booking Get(int Id)
        {

        }

        public void Edit(Booking booking)
        {

        }
    }
}