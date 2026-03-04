
using College_WebApplication.Data1;
using CollegeWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CollegeWebApplication.Controllers
{
    public class EmployeeMasterController : Controller
    {
        private readonly CollegeWebDbContext _context;

        public EmployeeMasterController(CollegeWebDbContext context)
        {
            _context = context;
        }

        // GET: Employee/Index
        public IActionResult Index()
        {
            var employeeList = _context.EmployeesMaster.ToList();
            return View(employeeList);
        }

        // GET: Employee/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public IActionResult Create(EmployeesMaster employee)
        {
            if (ModelState.IsValid)
            {
                _context.EmployeesMaster.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employee = _context.EmployeesMaster.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit
        [HttpPost]
        public IActionResult Edit(EmployeesMaster employee)
        {
            if (ModelState.IsValid)
            {
                _context.EmployeesMaster.Update(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employee/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _context.EmployeesMaster.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/DeleteConfirmed
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var employee = _context.EmployeesMaster.Find(id);
            if (employee != null)
            {
                _context.EmployeesMaster.Remove(employee);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}