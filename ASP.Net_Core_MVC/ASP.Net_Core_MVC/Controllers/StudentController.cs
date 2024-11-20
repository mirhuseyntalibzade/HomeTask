using ASP.Net_Core_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_MVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student1 = new Student("Alice", "Smith", new DateTime(2000, 1, 1), "alice@example.com", "1234567890");
            Student student2 = new Student("Bob", "Jones", new DateTime(1999, 5, 15), "bob@example.com", "9876543210");

            List<Student> students = new List<Student>() { student1, student2 };
            return View(students);
        }
    }
}
