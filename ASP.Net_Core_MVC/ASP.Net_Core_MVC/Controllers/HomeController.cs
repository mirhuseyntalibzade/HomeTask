using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
