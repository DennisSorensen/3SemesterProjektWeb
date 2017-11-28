using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class SupporterListVM
    {
        public List<SupporterVM> Supporters { get; set; }
        public SupporterListVM()
        {
            Supporters = new List<SupporterVM>();

        }

       
    }
}