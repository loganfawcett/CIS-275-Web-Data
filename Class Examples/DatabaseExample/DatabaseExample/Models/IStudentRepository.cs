using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> Students { get; }

    }
}
