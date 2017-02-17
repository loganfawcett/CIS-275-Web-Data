using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //  App
            Product[] products = {
                new Product { ProductID = 1, Name = "Kayak", Category = "Watersports", Price = 275M },
                new Product { ProductID = 2, Name = "Lifejacket", Category = "Watersports", Price = 48.95M },
                new Product { ProductID = 3, Name = "Soccer ball", Category = "Soccer", Price = 19.50M },
                new Product { ProductID = 4, Name = "Soccer ball", Category = "Soccer", Price = 15.95M },
                new Product { ProductID = 5, Name = "Corner flag", Category = "Soccer", Price = 34.95M },
                new Product { ProductID = 6, Name = "Hammock", Category = "Leisure", Price = 115M }
            };
            foreach (Product element in products)
            {
                Console.WriteLine(element.Name);
            }


            var over100 =
                from p in products
                where p.Price > 100M
                orderby p.Price
                select p;
            Console.WriteLine("All products over $100");
            foreach (var element in over100)
            {
                Console.WriteLine( "{0}: Price: {1}", element.Name, element.Price);
            }
        }
    }
}
