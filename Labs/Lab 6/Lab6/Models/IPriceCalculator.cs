using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Models
{
    public interface IPriceCalculator
    {
        decimal CalcSalesPrice(decimal origPrice);
    }
}
