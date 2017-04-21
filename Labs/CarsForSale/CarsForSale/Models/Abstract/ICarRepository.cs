using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsForSale.Models.Abstract
{
    interface ICarRepository
    {
        IEnumerable<Car> Cars { get; }
    }
}
