using System.Web.Mvc;
using System.Linq;
using EssentialTools.Models;
namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        IValueCalculator myCalc;

        public HomeController(IValueCalculator calcPassedIn)
        {
            myCalc = calcPassedIn;
        }

        private Product[] products = {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
};
        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart(myCalc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}