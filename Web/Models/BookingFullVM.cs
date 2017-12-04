using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class BookingFullVM
    {
        public int UserId { get; set; }
        public int CalendarId { get; set; }
        public DateTime StartDate { get; set; }
    }  
}