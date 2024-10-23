using Microsoft.AspNetCore.Mvc;

namespace LearnApiConsumption_MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
