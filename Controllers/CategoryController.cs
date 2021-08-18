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

        // [HttpGet("")]
        // public IActionResult Redirect()
        // {
        //     return RedirectToAction("Index");
        // }
    }
}