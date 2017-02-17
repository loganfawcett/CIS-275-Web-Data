using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Hello World
            Console.WriteLine("Hello World");

            //  App
            Product myProduct = new Product { ProductID = 234, Name = "Wilson Basketball", Description = "Regulation-Size BasketBall", Category = "Basketball", Price = 19.99M };
            Console.WriteLine();
        }
    }
}
