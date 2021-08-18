using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProdsNCats.Models;
using Microsoft.EntityFrameworkCore;

namespace ProdsNCats.Controllers
{
    public class CategoryController : Controller
    {

        private ProdsNCatsContext db;

        public CategoryController(ProdsNCatsContext context)
        {
            db = context;
        }

        [HttpGet("Categories")]
        public IActionResult Category()
        {
            List<Category> allCategories = db.Categories
            .ToList();
            return View("Categories", allCategories);
        }

        [HttpPost("/Categories/AddCategory")]
        public IActionResult AddCategory(Category newCategory)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Categories");
            }
            db.Add(newCategory);
            db.SaveChanges();
            return RedirectToAction("Categories");
        }
    }
}