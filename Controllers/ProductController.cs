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
    public class ProductController : Controller
    {

        private ProdsNCatsContext db;

        public ProductController(ProdsNCatsContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Redirect()
        {
            List<Product> allProducts = db.Products
            .ToList();
            return View("Products", allProducts);
        }

        [HttpGet("Products")]
        public IActionResult Product()
        {
            List<Product> allProducts = db.Products
            .ToList();
            return View("Products", allProducts);
        }

        [HttpPost("/Products/AddProduct")]
        public IActionResult AddProduct(Product newProduct)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Products");
            }
            db.Add(newProduct);
            db.SaveChanges();
            return RedirectToAction("Products");
        }

        [HttpGet("/Product/{ProductId}")]
        public IActionResult GetProduct(int productID)
        {
            Product product = db.Products.FirstOrDefault(p => p.ProductId == productID);
            if (product == null)
            {
                return RedirectToAction("Products");
            }
            ViewBag.allCategories = db.Categories.ToList();
            return View("Product", product);
        }

        [HttpPost("/products/{productId}/addCat")]
        public IActionResult AddCat(int productId)
        {
            // var AddCategory = db.Products
            // .Include(p => p.Category)
            return View("Product");
        }
    }
}