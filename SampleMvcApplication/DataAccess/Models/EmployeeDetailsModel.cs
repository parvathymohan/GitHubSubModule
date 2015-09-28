using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
   public  class EmployeeDetailsModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDesignation { get; set; }
        public string EmployeeAddress { get; set; }
        public int EmployeeAge { get; set; }
    }
}
