using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_3.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Extension { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
    }
}