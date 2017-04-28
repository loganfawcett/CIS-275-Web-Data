using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstExample.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [DisplayName("Department")]
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}