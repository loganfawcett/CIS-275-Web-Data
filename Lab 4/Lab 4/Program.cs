using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Line = "____________________________________________________________";
            Car[] myCars = {
                new Car {   Make = "Subaru",      Model = "Outback XT",     Year = 2005,    Engine = "4-H",     Asperation = "Turbocharged" },
                new Car {   Make = "Dodge",       Model = "Viper",          Year = 2003,    Engine = "10-V",    Asperation = "N/A" },
                new Car {   Make = "Nissan",      Model = "GTR",            Year = 2017,    Engine = "6-V",     Asperation = "Turbocharged-Twin" },
                new Car {   Make = "Lamborghini", Model = "Murcielago",     Year = 2005,    Engine = "10-V",    Asperation = "N/A" },
                new Car {   Make = "Ford",        Model = "Shelby GT500",   Year = 2017,    Engine = "8-V",     Asperation = "Supercharged" },
                new Car {   Make = "Bugatti",     Model = "Veyron",         Year = 2017,    Engine = "16-W",    Asperation = "Turbocharged-Quad" }
            };
     //  All
            Console.WriteLine("All Cars:\n");
            foreach (Car element in myCars)
            {
                Console.WriteLine("Make: {0}Model: {1}", element.Make, element.Model);
                //Console.WriteLine(element.Display);
            }
            Console.WriteLine(Line);

     // Sorted
            var sort =
                from c in myCars
                orderby c.Make
                select c;
            Console.WriteLine("\nSorted:");
            foreach (var element in sort)
            {
                Console.WriteLine(element.Display);
            }
            Console.WriteLine(Line);

     // Asperation
            var asperation =
                from c in myCars
                orderby c.Asperation
                select c;
            Console.WriteLine("\nAsperation:\n" + myCars[0].Header);
            foreach (var element in asperation)
            {
                Console.WriteLine(element.Display);
            }
            Console.WriteLine(Line);




            /*  Old Output
            Console.WriteLine(myCars[0].Header);
            foreach (Car element in myCars)
            {
                Console.WriteLine(element.Display);
            }
            */
        }
    }
}
