using FrontToBack.DAL;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace FrontToBack.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TablesController : Controller
    {
        readonly AppDBContext _context;
        public TablesController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Work> works = _context.Works.ToList();
            return View(works);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Work work)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Something went wrong");
            }
            _context.Works.Add(work);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int Id) 
        {
            Work deletedWork = _context.Works.Find(Id);
            if (deletedWork == null)
            {
                return NotFound();
            }else
            {
                _context.Works.Remove(deletedWork);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int Id)
        {
            Work work = _context.Works.Find(Id);
            if (work == null)
            {
                return NotFound();
            }
            return View(work);
        }

        [HttpPost]
        public IActionResult Edit(Work updatedWork)
        {
            Work existingWork = _context.Works.Find(updatedWork.Id);
            if (existingWork == null)
            {
                return NotFound();
            }

            existingWork.Title = updatedWork.Title;
            existingWork.Description = updatedWork.Description;
            existingWork.ImageURL = updatedWork.ImageURL;
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
