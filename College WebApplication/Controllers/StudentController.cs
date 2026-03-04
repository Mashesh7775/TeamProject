
using College_WebApplication.Data1;
using College_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CollageWebApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly CollegeWebDbContext _context;

        public StudentController(CollegeWebDbContext context)
        {
            _context = context;
        }

        // INDEX
        public IActionResult Index()
        {
            var students = _context.Studentinfos.ToList();
            return View(students);
        }

        // CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Studentinfo student)
        {
            if (ModelState.IsValid)
            {
                _context.Studentinfos.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);

        }

        
        // ================= DETAILS =================
        [HttpGet]
        public IActionResult Details(int id)
        {
            var student = _context.Studentinfos.Find(id);

            if (student == null)
            {
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // ================= DELETE GET =================
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _context.Studentinfos.Find(id);

            if (student == null)
            {
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // ================= DELETE POST =================
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _context.Studentinfos.FirstOrDefault(s => s.StudentId == id);

            if (student == null)
            {
                return NotFound();
            }

            _context.Studentinfos.Remove(student);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Student/Edit/5
        public IActionResult Edit(int id)
        {
            var student = _context.Studentinfos.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

    }
}
