using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class AvailableSessionsListVM
    {
        public AvailableSessionsListVM()
        {
            AvailableSessions = new List<SessionVM>();
        }

        public List<SessionVM> AvailableSessions { get; set; }

    }
}