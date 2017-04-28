using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace CodeFirstExample.Models
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CodeFirstExampleContext>
    {
        protected override void Seed(CodeFirstExampleContext context)
        {
            var departments = new List<Department>
                {
                new Department{Name="Mathematics"},
                new Department{Name="Computer Science"},
                new Department{Name="History"},
                new Department{Name="English"}
                };
            departments.ForEach(d => context.Departments.Add(d));
            context.SaveChanges();
            var courses = new List<Course>
                {
                new Course{DepartmentID=1,Title="College Algebra"},
                new Course{DepartmentID=4,Title="English Comp I"},
                new Course{DepartmentID=2,Title="Programming Fundamentals"}
                };
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();
        }
    }
}