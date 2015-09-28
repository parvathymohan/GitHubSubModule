using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMvcApplication.Models
{

    
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDesignation { get; set; }
        public string EmployeeAddress { get; set; }
        public int EmpoyeeSalary { get; set; }
    }
}