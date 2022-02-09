using Microsoft.AspNetCore.Mvc;
using PriceQuotationApp.Models;

namespace PriceQuotationApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.discountAmount = 0;
            ViewBag.Total = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.discountAmount = model.DiscountAmount();
                ViewBag.Total = model.TotalAmount();
            }
            else {
                ViewBag.discountAmount = 0;
                ViewBag.Total = 0;
            }

            return View(model);
        }
    }
}
