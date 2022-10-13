using DisasterWebsiteAppr.Data;
using DisasterWebsiteAppr.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterWebsiteAppr.Controllers
{
    public class CategoryController : Controller
    {

        private readonly AlleviationContext context;

        public CategoryController(AlleviationContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var result = context.Categories.ToList();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                var data = new Category()
                {
                    CName = model.CName
                };

                context.Categories.Add(data);
                context.SaveChanges();
                TempData["message"] = "Category Saved!";
                return RedirectToAction("Index", "Category");
            }
            else
            {
                TempData["message"] = "Empty field can't be submited!";
                return View(model);
            }

        }


    }
}
