using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarterFileExam2.Models
{
    public interface ICarRepository
    {
       IEnumerable<Car> Cars { get; }

    }
}