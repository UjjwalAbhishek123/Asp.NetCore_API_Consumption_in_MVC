using Microsoft.AspNetCore.Mvc;

namespace LearnApiConsumption_MVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            //For loading List of Customer information
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(string code)
        {
            ViewData["editCode"] = code;
            return View();
        }
    }
}
