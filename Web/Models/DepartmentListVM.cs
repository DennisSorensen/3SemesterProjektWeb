using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class DepartmentListVM
    {
        public DepartmentListVM()
        {
            Departments = new List<DepartmentVM>();
        }

        public List<DepartmentVM> Departments { get; set; }
    }
}