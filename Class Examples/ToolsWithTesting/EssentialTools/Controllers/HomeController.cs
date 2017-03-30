using System.Web.Mvc;
using System.Linq;
using EssentialTools.Models;
namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private ITaxCalculator calc;
        decimal income = 45000;
     

        public HomeController(ITaxCalculator calcParam)
        {
            calc = calcParam;
        }
        public ActionResult Index()
        {
            decimal tax = calc.FindTaxAmount(income);
                return View(tax);
        }
    }
}