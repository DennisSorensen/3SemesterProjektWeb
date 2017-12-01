using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class BookingSpecificDayListVM
    {
        public BookingSpecificDayListVM()
        {
            Bookings = new List<BookingVM>();
        }

        public List<BookingVM> Bookings { get; set; }

    }
}