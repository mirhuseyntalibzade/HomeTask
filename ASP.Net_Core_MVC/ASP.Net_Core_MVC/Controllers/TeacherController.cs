using ASP.Net_Core_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_MVC.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            Teacher teacher1 = new Teacher("John", "Doe", "john.doe@example.com", "123-456-7890");
            Teacher teacher2 = new Teacher("Jane", "Smith", "jane.smith@example.com", "987-654-3210");

            List<Teacher> teachers = new List<Teacher>() { teacher1, teacher2 };
            return View(teachers);
        }
    }
}
