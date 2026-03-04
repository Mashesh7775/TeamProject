using College_WebApplication.Data1;
using College_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace College_WebApplication.Controllers
{
    public class CountryMasterController : Controller
    {
        private readonly CollegeWebDbContext _context;

        public CountryMasterController (CollegeWebDbContext context )
        {
            _context = context;


        }
        public IActionResult Index()
        {
            var ContryList = _context.CountryMasters.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
         public IActionResult Create (CountryMaster countryMaster)
        {
            if (ModelState.IsValid)
            {
                _context.CountryMasters.Add(countryMaster);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]

        public IActionResult Edit(int id)
        {
            var country = _context.CountryMasters.Find(id);
            if (country == null)
            {
                return RedirectToAction(nameof(Index));
         
            }
            return View(country);
        }
       
        [HttpPost]

        public IActionResult Edit(int id, CountryMaster countryMaster) 
        {
            if (ModelState.IsValid)
            {
                _context.CountryMasters.Update(countryMaster);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(countryMaster);




        }
        

    
        }
    }





