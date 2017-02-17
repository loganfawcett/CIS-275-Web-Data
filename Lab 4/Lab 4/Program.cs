using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] myCars = {
                new Car { Make = "Subaru", Model = "Outback XT", Year = 2005, Engine = "4-H", Asperation = "Turbocharged" },
                new Car { Make = "Dodge", Model = "Viper", Year = 2003, Engine = "10-V", Asperation = "N/A" },
                new Car { Make = "Nissan", Model = "GTR", Year = 2017, Engine = "6-V", Asperation = "Twin-Turbocharged" },
                new Car { Make = "Lamborghini", Model = "Murcielago", Year = 2005, Engine = "10-V", Asperation = "N/A" },
                new Car { Make = "Ford", Model = "Shelby GT500", Year = 2017, Engine = "8-V", Asperation = "Supercharged" },
                new Car { Make = "Bugatti", Model = "Veyron", Year = 2017, Engine = "16-W", Asperation = "Quad-Turbocharged" }
            };


            Console.WriteLine("Make:\t\tModel:\t\tYear:\tEngine:\tAsperation:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(myCars[i].Display);
            }
        }
    }
}
