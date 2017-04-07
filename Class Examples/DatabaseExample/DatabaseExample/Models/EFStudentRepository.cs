using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseExample.Models
{
    public class EFStudentRepository : IStudentRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Student> Students
        {
            get { return context.Students; }
        }
    }
}