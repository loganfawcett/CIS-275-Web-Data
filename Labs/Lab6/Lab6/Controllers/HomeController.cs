using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab6.Models;

namespace Lab6.Controllers
{
    public class HomeController : Controller
    {


        IPriceCalculator myPrice;
        public HomeController(IPriceCalculator pricePassedIn)
        {
            myPrice = pricePassedIn;
        }

        StoreItem item = new StoreItem { Name = "Sofa", Category = "Furniture", Price = 935.95M, Discountable = true };

    // GET: Home
    public ActionResult Index()
        {
            if (item.Discountable == true)
            {
                decimal totalValue = myPrice.CalcSalesPrice(item.Price);
                return View(totalValue);
            }
            else
            {
                return View(item.Price);
            }     
        }
    }
}