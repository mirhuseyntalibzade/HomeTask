using ASP.Net_Core_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_MVC.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            Group group = new Group()
            {
                ClassName = "AB205"
            };
            Group group1 = new Group()
            {
                ClassName = "AF208"
            };
            List<Group> groups = new List<Group>() { group, group1 };
            return View(groups);
        }
    }
}
